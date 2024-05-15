using System;
using System.Collections.Generic;

namespace DesarrolloP.Models
{
    public partial class Perfil
    {
        public Perfil()
        {
            Usuarios = new HashSet<Usuario>();
        }

        public int PerfilId { get; set; }
        public string? NombrePerfil { get; set; }
        public string? Descripcion { get; set; }

        public virtual ICollection<Usuario> Usuarios { get; set; }
    }
}
