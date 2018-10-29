using System;
using System.Collections.Generic;
using System.Text;

namespace SGL.ApplicationCore.Entity
{
    public class Lanchonete
    {
        public Lanchonete()
        {
                
        }

        public int Id { get; set; }

        public int PedidoId { get; set; }

        public Pedido Pedido { get; set; }

        public int LancheId { get; set; }

        public Lanche Lanche { get; set; }
    }
}
