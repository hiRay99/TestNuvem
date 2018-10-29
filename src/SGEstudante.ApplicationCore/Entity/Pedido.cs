using System;
using System.Collections.Generic;
using System.Text;

namespace SGL.ApplicationCore.Entity
{
   public class Pedido
    {
        public Pedido ()
        {

        }

        public int PedidoId { get; set; }

        public String Nome { get; set; }

        public String Valor{ get; set; }

        public String TipoLanche { get; set; }

        // public Endereco Endereco { get; set; }

        // public ICollection<QuantidadeLanche> QuantidadeLanche { get; set; }

        // public ICollection<Lanche> Lanches { get; set; }

    }
}
