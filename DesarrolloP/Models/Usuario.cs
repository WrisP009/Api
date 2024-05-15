using System;
using System.Collections.Generic;

namespace DesarrolloP.Models
{
    public partial class Usuario
    {
        public int UsuarioId { get; set; }
        public int? PersonaId { get; set; }
        public int? PerfilId { get; set; }
        public string? NombreUsuario { get; set; }
        public string? Contraseña { get; set; }

        public virtual Perfil? Perfil { get; set; }
        public virtual Persona? Persona { get; set; }
    }
}
