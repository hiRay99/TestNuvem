using System;
using System.Collections.Generic;
using System.Text;

namespace SGEstudante.ApplicationCore.Entity
{
    public class Endereco
    {
        public Endereco()
        {

        }

        public int EnderecoId { get; set; }

        public string Lougradouro { get; set; }

        public string Bairro { get; set; }

        public string CPE { get; set; }

        public string Referencia { get; set; }

        public int EstudanteId { get; set; }

        public Estudante Estudante { get; set; }
    }
}
