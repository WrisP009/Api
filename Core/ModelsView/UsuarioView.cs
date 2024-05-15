using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.ModelsView
{
    public class UsuarioView
    {
        public int UsuarioId { get; set; }
        public int? PersonaId { get; set; }
        public int? PerfilId { get; set; }
        public string? NombreUsuario { get; set; }
        public string? Contraseña { get; set; }
    }
}
