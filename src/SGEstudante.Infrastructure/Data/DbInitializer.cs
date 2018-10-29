using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using SGL.ApplicationCore.Entity;

namespace SGL.Infrastructure.Data
{
    public static class DbInitializer
    {
        public static void Initiatize(LanchoneteContext context)
        {
            if (context.Pedidos.Any())
            {
                return;
            }

            var Estudantes = new Pedido[]
            {
                new Pedido
                {
                     Nome = "Pedido 01",
                     TipoLanche = "X-Bacon",
                     Valor = "R$ 5,00"

                },


                new Pedido
                {
                    Nome = "Pedido 02",
                    TipoLanche = "Cacho-quente",
                    Valor = "R$ 3,00"
                },

                new Pedido
                {
                    Nome = "Pedido 03",
                    TipoLanche = "X-Salada",
                    Valor = "R$ 2,50"
                },

                new Pedido
                {
                    Nome = "Pedido 04",
                    TipoLanche = "Torrada simples",
                    Valor = "R$ 4,50"
                },

                 new Pedido
                {
                    Nome = "Pedido 05",
                    TipoLanche = "Refrigerante",
                    Valor = "R$ 1,50"
                }
            };

            context.AddRange(Estudantes);

            context.SaveChanges();
        }

        public static void Initialize(LanchoneteContext context)
        {
            throw new NotImplementedException();
        }
    }
}
