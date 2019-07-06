using ConsultaCEP.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsultaCEP.Models
{
    public class Context : DbContext
    {

        public Context(DbContextOptions<Context> options) : base(options)
        {
            //injeção de dependencia 


        }

        public DbSet<CEP> CEPs { get; set; }



    }
}
