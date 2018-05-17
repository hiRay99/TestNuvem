using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace SGEstudante.Infrastructure.Data
{
    public class EstudanteContext : DbContext
    {
        public EstudanteContext(DbContextOptions<EstudanteContext> options) : base(options)
        {
                
        }
    }
}
