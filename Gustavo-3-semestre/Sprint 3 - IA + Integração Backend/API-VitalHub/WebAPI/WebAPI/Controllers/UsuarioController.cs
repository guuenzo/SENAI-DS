using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IdentityModel.Tokens.Jwt;
using System.Runtime.CompilerServices;
using WebAPI.Domains;
using WebAPI.Interfaces;
using WebAPI.Repositories;
using WebAPI.Utils.BlobStorage;
using WebAPI.ViewModels;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private IUsuarioRepository usuarioRepository { get; set; }

        public UsuarioController()
        {
            usuarioRepository = new UsuarioRepository();
        }

        [HttpPut("AlterarSenha")]
        public IActionResult UpdatePassword(string email, AlterarSenhaViewModel senha)
        {
            try
            {
                usuarioRepository.AlterarSenha(email, senha.SenhaNova!);

                return Ok("Senha alterada com sucesso !");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("BuscarPorId")]
        public IActionResult GetById(Guid id)
        {
            try
            {
                return Ok(usuarioRepository.BuscarPorId(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("AlterarFotoPerfil")]
        public async Task<IActionResult> UploadProfileImage(Guid id, [FromForm] UsuarioViewModel user)
        {
            try
            {
                Usuario usuarioBuscado = usuarioRepository.BuscarPorId(id);

                if (usuarioBuscado == null) { return NotFound(); }

                //logica para o upload de imagem 
                var connectionString = "DefaultEndpointsProtocol=https;AccountName=blobvitalhubg16enzo;AccountKey=oE4zwTcqqxKfuErbVv7o9ETdAbHzELSZDt7o60W5hQ07zfFdTU4YuZIGtOyVKRjh3E3GzJwRnAHn+AStsOUjgA==;EndpointSuffix=core.windows.net";

                var containerName = "containervitalhubg16enzo";

                string fotoUrl = await AzureBlobStorageHelper.UploadImageBlobAsync(user.Arquivo!, connectionString, containerName );
                //fim do upload de imagem

                usuarioBuscado.Foto = fotoUrl;

                usuarioRepository.AtualizarFoto(id, fotoUrl);

                return Ok();
            }
            catch (Exception ex)
            {

                return( BadRequest(ex.Message));
            }
        }
    }
}
