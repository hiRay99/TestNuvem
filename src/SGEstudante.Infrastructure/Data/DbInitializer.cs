using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using SGEstudante.ApplicationCore.Entity;

namespace SGEstudante.Infrastructure.Data
{
    public static class DbInitializer
    {
        public static void Initiatize(EstudanteContext context)
        {
            if (context.Estudantes.Any())
            {
                return;
            }

            var Estudantes = new Estudante[]
            {
                new Estudante
                {
                     Nome = "Rayane Ribeiro",
                     CPF = "84833826100"
                },


                new Estudante
                {
                    Nome = "Rayane Fernandes",
                    CPF = "47275602911"
                }
            };

            context.AddRange(Estudantes);

            var contatos = new Contato[]
            {
                new Contato
                {
                    Nome ="Contato 1 ",
                    Telefone = "999999999",
                    Email = "email_contato1@gmail.com",
                    Estudante = Estudantes[0]
                },

                new Contato
                {
                    Nome ="Contato 2 ",
                    Telefone = "888888888",
                    Email = "email_contato2@gmail.com",
                    Estudante = Estudantes[1]
                }
            };

            context.AddRange(contatos);

            context.SaveChanges();
        }

        public static void Initialize(EstudanteContext context)
        {
            throw new NotImplementedException();
        }
    }
}
