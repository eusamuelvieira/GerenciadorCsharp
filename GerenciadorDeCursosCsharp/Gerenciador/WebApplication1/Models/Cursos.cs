using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GerenciadorDeCursos.Models
{
    public class Cursos
    {
        public int Id { get;set; }
        public String Titulo { get; set; }
        public String Duracao { get; set; }
        public String Status { get; set; }
    }
}
