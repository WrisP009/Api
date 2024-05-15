using Core.ModelsView;
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
        PersonaView ActualizarP(int id, PersonaView personaView);
        PersonaView EliminarPorId(int id);
        PersonaView buscarid(int id);

        PerfilView AgregarP(int id, PersonaView personaView);
    }
}
