using Business.Interfaces;
using Core.ModelsView;
using Infraestrucuta.Models;
using Microsoft.EntityFrameworkCore;
using Infraestrucuta.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Implementations
{
    public class UsuarioServices : IUsuarioServices
    {
        //private readonly Desarrollo_plataformasContext _dbContext;

        //public UsuarioServices(Desarrollo_plataformasContext dbContext)
        //{
        //    _dbContext = dbContext;
        //}

        //public List<UsuarioView> ConsultarUsuarios()
        //{
        //    List<UsuarioView> listaUsuariosView = new List<UsuarioView>();
        //    var usuarios = _dbContext.Usuarios.Include(u => u.Persona).ToList();

        //    foreach (var usuario in usuarios)
        //    {
        //        UsuarioView usuarioView = new UsuarioView
        //        {
        //            UsuarioId = usuario.UsuarioId,
        //            NombreUsuario = usuario.NombreUsuario,
        //            Contraseña = usuario.Contraseña,

        //            Persona = new PersonaView
        //            {
        //                PersonaId = usuario.PersonaId,
        //                Nombre = usuario.Persona.Nombre,
        //                Apellido = usuario.Persona.Apellido,
        //                CorreoElectronico = usuario.Persona.CorreoElectronico
        //            }
        //        };
        //        listaUsuariosView.Add(usuarioView);
        //    }

        //    return listaUsuariosView;
        //}

        //public UsuarioView BuscarUsuarioPorId(int id)
        //{
        //    var usuario = _dbContext.Usuarios.Include(u => u.Persona).FirstOrDefault(u => u.UsuarioId == id);

        //    if (usuario == null)
        //    {
        //        return null;
        //    }

        //    UsuarioView usuarioView = new UsuarioView
        //    {
        //        UsuarioId = usuario.UsuarioId,
        //        NombreUsuario = usuario.NombreUsuario,
        //        Contraseña = usuario.Contraseña,

        //        Persona = new PersonaView
        //        {
        //            PersonaId = usuario.PersonaId,
        //            Nombre = usuario.Persona.Nombre,
        //            Apellido = usuario.Persona.Apellido,
        //            CorreoElectronico = usuario.Persona.CorreoElectronico
        //        }
        //    };
        //    return usuarioView;
        //}

        //public bool EliminarUsuarioPorId(int id)
        //{
        //    var usuario = _dbContext.Usuarios.Find(id);

        //    if (usuario == null)
        //    {
        //        return false;
        //    }

        //    _dbContext.Usuarios.Remove(usuario);
        //    _dbContext.SaveChanges();
        //    return true;
        //}

        //public bool ActualizarUsuario(int id, UsuarioView usuarioView)
        //{
        //    var usuario = _dbContext.Usuarios.Find(id);

        //    if (usuario == null)
        //    {
        //        return false;
        //    }

        //    usuario.NombreUsuario = usuarioView.NombreUsuario;
        //    usuario.Contraseña = usuarioView.Contraseña;
        //    _dbContext.SaveChanges();
        //    return true;
        //}

        //public bool AgregarUsuario(UsuarioView usuarioView)
        //{
        //    var usuarioExistente = _dbContext.Usuarios.Find(usuarioView.UsuarioId);

        //    if (usuarioExistente != null)
        //    {
        //        return false;
        //    }


        //    var personaExistente = _dbContext.Personas.Find(usuarioView.Persona.PersonaId);

        //    if (personaExistente == null)
        //    {
        //        return false;
        //    }


        //    var nuevoUsuario = new Usuario
        //    {
        //        UsuarioId = usuarioView.UsuarioId,
        //        NombreUsuario = usuarioView.NombreUsuario,
        //        Contraseña = usuarioView.Contraseña,
        //        PersonaId = usuarioView.Persona.PersonaId
        //    };

        //    _dbContext.Usuarios.Add(nuevoUsuario);
        //    _dbContext.SaveChanges();
        //    return true;
        //}
    }

}
