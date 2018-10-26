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

        public int LancheId { get; set; }

        public String Nome { get; set; }

        public Decimal Valor{ get; set; }

        public Endereco Endereco { get; set; }

        public ICollection<QuantidadeLanche> QuantidadeLanche { get; set; }
        
        public ICollection<CursoEstudante> CursosEstudante { get; set; }
        
    }
}
