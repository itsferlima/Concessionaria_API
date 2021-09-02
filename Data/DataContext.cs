using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class DataContext : DbContext
    {
        //Construtor
        public DataContext(DbContextOptions<DataContext> options): base(options) { }

        public DbSet<Carro> Carros {get; set;}
    }
}