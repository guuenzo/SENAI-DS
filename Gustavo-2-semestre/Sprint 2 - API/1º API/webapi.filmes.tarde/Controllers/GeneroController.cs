using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using webapi.filmes.tarde.Domains;
using webapi.filmes.tarde.Interfaces;
using webapi.filmes.tarde.Repositories;

namespace webapi.filmes.tarde.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class GeneroController : ControllerBase
    {
        /// <summary>
        ///Objeto que ira receber os metodos definidos na interface
        /// </summary>
        private IGeneroRepository _generoRepository { get; set; }

        /// <summary>
        /// Instancia do objeto _generoRepository para que haja referencia aos metodos no repositorio
        /// </summary>
        public GeneroController()
        {
            _generoRepository = new GeneroRepository();
        }

        /// <summary>
        /// Endpoint que acessa o metodo de listar os generos
        /// </summary>
        /// <returns>Lista de generos e um status code</returns>
        [HttpGet]
        [Authorize]//Precisa estar logado para acessar a rota
        public IActionResult Get()
        {
            try
            {
                //Cria uma lista para receber os generos 
                List<GeneroDomain> ListaGeneros = _generoRepository.ListarTodos();

                //Retorna o status code 200 - Ok e a lista de generos formato JSON
                return Ok(ListaGeneros);
            }
            catch (Exception erro)
            {
                //Retorna um status code 400 - BadRequest e a mensagem de erro
                return BadRequest(erro);
            }


        }

        /// <summary>
        /// Endpoint que acessa o metodo de cadastrar os generos
        /// </summary>
        /// <param name="novoGenero">Objeto recebido na requisicao</param>
        /// <returns>generos cadastrados</returns>
        [HttpPost]
        public IActionResult Post(GeneroDomain novoGenero)
        {
            try
            {
                //Acessa o repositorio atraves do objeto invocando um metodo passando o objeto a ser cadastrado como parametro
                _generoRepository.Cadastrar(novoGenero);

                //Retorna o status code 201 - Created e o objeto cadastrado em formato JSON
                return Created("objeto criado", novoGenero);
            }
            catch (Exception erro)
            {
                //Retorna um status code 400 - BadRequest e a mensagem de erro
                return BadRequest(erro);
            }
        }

        [HttpDelete ("{id}")]
        public IActionResult Delete(int id) 
        {
            try
            {
                _generoRepository.Deletar(id);

                return StatusCode(204);
            }
            catch (Exception erro)
            {
                return BadRequest(erro);
            }
        }

        [HttpGet ("{id}")]
        public IActionResult Get(int id) 
        {
            try
            {
                GeneroDomain generoBuscado = _generoRepository.BuscarPorId(id);

                if(generoBuscado == null) 
                {
                    return NotFound("O Gênero buscado não foi encontrao");
                }

                return Ok(generoBuscado);
            }
            catch (Exception erro)
            {
                return BadRequest(erro);
            }
        }

        [HttpPut("{id}")]
        public IActionResult PutIdUrl(int id, GeneroDomain genero) 
        {
            try
            {
                _generoRepository.AtualizarIdUrl(id, genero);

                return Ok();
            }
            catch (Exception erro)
            {
                return BadRequest(erro);
            }
        }

        [HttpPut]
        public IActionResult PutIdBody(GeneroDomain genero) 
        {
            try
            {
                GeneroDomain generoBuscado = _generoRepository.BuscarPorId(genero.IdGenero);

                if (generoBuscado != null)
                {
                    try
                    {
                        _generoRepository.AtualizarIdCorpo(genero);

                        return NoContent();
                    }
                    catch (Exception erro)
                    {
                        return BadRequest(erro);
                    }   
                }
                return NotFound();
            }
            catch (Exception erro)
            {
                return BadRequest(erro);
            }
        }
    }
}
