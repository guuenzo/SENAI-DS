using HealthClinic_tarde.Domains;
using HealthClinic_tarde.Interfaces;
using HealthClinic_tarde.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HealthClinic_tarde.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class ConsultaController : ControllerBase
    {
        IConsultaRepository _consultaRepository;

        public ConsultaController()
        {
            _consultaRepository = new ConsultaRepository();
        }

        [HttpGet]
        [Authorize(Roles = "Médico")]
        [Authorize(Roles ="Paciente")]
        public IActionResult Get()
        {
            try
            {
                return Ok(_consultaRepository.Listar());
            }
            catch (Exception erro)
            {
                return BadRequest();
            }
        }

        [HttpDelete]
        [Authorize(Roles ="Administrador")]
        public IActionResult Delete(Guid id, Consulta consulta)
        {
            try
            {
                _consultaRepository.Deletar(id, consulta);

                return Ok();
            }
            catch (Exception erro)
            {
                return BadRequest();
            }
        }

        [HttpPost]
        [Authorize(Roles ="Administrador")]
        public IActionResult Post(Consulta consulta)
        {
            try
            {
                _consultaRepository.Cadastrar(consulta);

                return Ok();
            }
            catch (Exception erro)
            {
                return BadRequest();
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            try
            {
                return Ok(_consultaRepository.BuscarPorId(id));
            }
            catch (Exception erro)
            {
                return BadRequest(erro.Message);
            }
        }
    }
}
