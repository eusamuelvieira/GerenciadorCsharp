using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciadorDeCursos.Models
{
    public class Usuarios
    {
        public int Id { get; set; }
        public String Nome { get; set; }
        public String Cargo { get; set; }
    }
}
