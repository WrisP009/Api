using Core.ModelsView;
using Infraestrucuta.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    public interface IPersonaServices
    {
        List<PersonaView> ConsultarServicios();
        Persona ActualizarP(int id, PersonaView personaView);
        bool EliminarPorId(int id);
        PersonaView buscarid(int id);

        Persona AgregarP(int id, PersonaView personaView);
    }
}
