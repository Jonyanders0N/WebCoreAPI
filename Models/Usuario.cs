using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebCoreAPI.Models
{
    public class Usuario
    {
        public long UsuarioId { get; set; }
        public string NmUsuario { get; set; }
        public string senhaUsuario { get; set; }
        public string emailUsuario { get; set; }
    }
}
