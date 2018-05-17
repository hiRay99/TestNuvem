using System;
using System.Collections.Generic;
using System.Text;

namespace SGEstudante.ApplicationCore.Entity
{
    public class Contato
    {
        public Contato()
        {
                
        }

        public int ContatoId { get; set; }

        public String Nome { get; set; }

        public String Telefone { get; set; }

        public String Email { get; set; }

        public int EstudanteId { get; set; }

        public Estudante Estudante { get; set; }
    }
}
