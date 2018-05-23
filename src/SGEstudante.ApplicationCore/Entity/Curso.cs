using System;
using System.Collections.Generic;
using System.Text;

namespace SGEstudante.ApplicationCore.Entity
{
    public class Curso
    {
        public Curso()
        {

        }
        public int CursoId { get; set; }

        public string Materia { get; set; }

        public string Descricao { get; set; }

        public string Codigo { get; set; }

        public ICollection<CursoEstudante> CursosEstudante { get; set; }
    }
}
