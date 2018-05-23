using System;
using System.Collections.Generic;
using System.Text;

namespace SGEstudante.ApplicationCore.Entity
{
    public class CursoEstudante
    {
        public CursoEstudante()
        {
                
        }

        public int Id { get; set; }

        public int EstudanteId { get; set; }

        public Estudante Estudante { get; set; }

        public int CursoId { get; set; }

        public Curso Curso { get; set; }
    }
}
