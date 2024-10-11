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