using Business.Interfaces;
using Core.ModelsView;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DesarrolloP.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonaController : ControllerBase
    {
        private readonly IPersonaServices _idpersona;

        public PersonaController(IPersonaServices ipersona)
        {
            _idpersona = ipersona;
        }
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            try
            {
                var listServicios = _idpersona.ConsultarServicios();
                return Ok(listServicios);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // GET: api/<PersonaController>
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        // GET api/<PersonaController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult> Getid(int id)
        {
            try
            {
                var BuscarId = _idpersona.buscarid(id);
                return Ok(BuscarId);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        // POST api/<PersonaController>
        //[HttpPost]
        //public async Task<ActionResult> POST([FromBody] PersonaView nuevaPersona)
        //{
        //    PersonaView NuevaPersona = new PersonaView()
        //    {
        //        PersonaId = id,
        //        Nombre = NNombre,
        //        Apellido = NApellido,
        //        CorreoElectronico = NCorreo,

        //    //};
        //    try
        //    {
        //        var AgregarP = _idpersona.AgregarP(nuevaPersona);
        //        return Ok(AgregarP);
        //    }
        //    catch (Exception ex)
        //    {
        //        return BadRequest(ex.Message);
        //    }

        //}
        [HttpPost]
        public async Task<ActionResult> POST([FromBody] PersonaView nuevaPersona)
        {
            try
            {
                var agregarP = _idpersona.AgregarP(nuevaPersona);
                if (agregarP == null)
                {
                    return Conflict("La persona ya existe.");
                }
                return Ok(agregarP);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.InnerException?.Message ?? ex.Message);
            }
        }

        //PUT api/<PersonaController>/5
        [HttpPut]
        public ActionResult PUT([FromBody] PersonaView nuevaPersona)
        {

            try
            {
                var Actualizarp = _idpersona.ActualizarP(nuevaPersona);
                return Ok(Actualizarp);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }

        // DELETE api/<PersonaController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            try
            {
                var Borrar = _idpersona.EliminarPorId(id);
                return Ok(Borrar);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

        }
    }
}
