using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;


namespace Infrastructure.Data
{
    public class MyContext : DbContext
    {
         public MyContext(DbContextOptions<MyContext> options): base(options){
            
            }

        public DbSet<Prueba> pruebas {get; set;}

    }
}