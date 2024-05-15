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
    public class UsuarioServices 
    { 
        private readonly Desarrollo_plataformasContext _dbContext;

        public UsuarioServices(Desarrollo_plataformasContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<UsuarioView> ConsultarUsuarios()
        {
            List<UsuarioView> listaUsuariosView = new List<UsuarioView>();
            var usuarios = _dbContext.Usuarios.Include(u => u.Persona).ToList();

            foreach (var usuario in usuarios)
            {
                UsuarioView usuarioView = new UsuarioView
                {
                    UsuarioId = usuario.UsuarioId,
                    PersonaId = usuario.PersonaId,
                    NombreUsuario = usuario.NombreUsuario,
                    Contraseña = usuario.Contraseña,
                    
                };
                listaUsuariosView.Add(usuarioView);
            }

            return listaUsuariosView;
        }

        public UsuarioView BuscarUsuarioPorId(int id)
        {
            var usuario = _dbContext.Usuarios.Include(u => u.Persona).FirstOrDefault(u => u.UsuarioId == id);

            if (usuario == null)
            {
                return null;
            }

            UsuarioView usuarioView = new UsuarioView
            {
                UsuarioId = usuario.UsuarioId,
                NombreUsuario = usuario.NombreUsuario,
                Contraseña = usuario.Contraseña,
                PersonaId=usuario.PersonaId,

            };
            return usuarioView;
        }

        public bool EliminarUsuarioPorId(int id)
        {
            var usuario = _dbContext.Usuarios.Find(id);

            if (usuario == null)
            {
                return false;
            }

            _dbContext.Usuarios.Remove(usuario);
            _dbContext.SaveChanges();
            return true;
        }

        public bool ActualizarUsuario(int id, UsuarioView usuarioView)
        {
            var usuario = _dbContext.Usuarios.Find(id);

            if (usuario == null)
            {
                return false;
            }

            usuario.NombreUsuario = usuarioView.NombreUsuario;
            usuario.Contraseña = usuarioView.Contraseña;
            _dbContext.SaveChanges();
            return true;
        }

        public Usuario AgregarUsuario(int id, UsuarioView usuarioView)
        {
            var usuarioExistente = _dbContext.Usuarios.Find(usuarioView.UsuarioId);

            if (usuarioExistente != null)
            {
                return null;
            }
            var Cusuario = new Usuario
            {
                UsuarioId = usuarioView.UsuarioId,
                PersonaId = usuarioView.PersonaId,
                NombreUsuario = usuarioView.NombreUsuario,
                Contraseña = usuarioView.Contraseña,
                
            };
            _dbContext.Usuarios.Add(Cusuario);
            _dbContext.SaveChanges();
            return Cusuario;
        }
    }

}
