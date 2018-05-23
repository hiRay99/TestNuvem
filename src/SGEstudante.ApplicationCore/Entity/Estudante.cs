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

        public String CPF{ get; set; }

        public int Inscricao { get; set; }
        
        public ICollection<Contato> Contatos { get; set; }

        public Endereco Endereco { get; set; }

        public ICollection<CursoEstudante> CursosEstudante { get; set; }
    }
}
