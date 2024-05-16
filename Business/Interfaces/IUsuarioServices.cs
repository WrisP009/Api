using Core.ModelsView;
using Infraestrucuta.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    public interface IUsuarioServices
    {
        List<UsuarioView> ConsultarUsuarios();
        Usuario ActualizarUsuario(int id, UsuarioView usuarioView);
        bool EliminarUsuarioPorId(int id);
        UsuarioView BuscarUsuarioPorId(int id);

        Usuario AgregarUsuario(int id, UsuarioView usuarioView);
    }
}
