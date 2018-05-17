using System;
using System.Collections.Generic;
using System.Text;

namespace SGEstudante.ApplicationCore.Entity
{
   public class Estudante
    {
        public Estudante()
        {

        }

        public int EstudanteId { get; set; }
        public String Nome { get; set; }
        public String Email { get; set; }
        public int Incricao { get; set; }
       
    }
}
