using Business.Interfaces;
using Core.ModelsView;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DesarrolloP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioServices _idusuario;

        public UsuarioController(IUsuarioServices iusuario)
        {
            _idusuario = iusuario;
        }
        // GET: api/<UsuarioController>
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            try
            {
                var listServicios = _idusuario.ConsultarUsuarios();
                return Ok(listServicios);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // GET api/<UsuarioController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult> Getid(int id)
        {
            try
            {
                var BuscarId = _idusuario.BuscarUsuarioPorId(id);
                return Ok(BuscarId);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        // POST api/<UsuarioController>
        [HttpPost]
        public async Task<ActionResult> Post(int id, string NNombreU, string NContasena, int NPersonaid)
        {
            UsuarioView NuevaUsuario = new UsuarioView()
            {
                UsuarioId = id,
                PersonaId = NPersonaid,
                NombreUsuario = NNombreU,
                Contraseña = NContasena,

            };
            try
            {
                var AgregarP = _idusuario.AgregarUsuario(id, NuevaUsuario);
                return Ok(AgregarP);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        // PUT api/<UsuarioController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, string NNombreU, string NContasena, int NPersonaid)
        {

            UsuarioView NuevaUsuario = new UsuarioView()
            {
                UsuarioId = id,
                PersonaId = NPersonaid,
                NombreUsuario = NNombreU,
                Contraseña = NContasena,

            };
            try
            {
                var AgregarP = _idusuario.ActualizarUsuario(id, NuevaUsuario);
                return Ok(AgregarP);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }


        }

        // DELETE api/<UsuarioController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            try
            {
                var Borrar = _idusuario.EliminarUsuarioPorId(id);
                return Ok(Borrar);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
    }
}
