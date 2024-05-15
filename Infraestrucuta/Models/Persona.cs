using System;
using System.Collections.Generic;

namespace Infraestrucuta.Models
{
    public partial class Persona
    {
        public Persona()
        {
            Usuarios = new HashSet<Usuario>();
        }

        public int PersonaId { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public string? CorreoElectronico { get; set; }

        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}
