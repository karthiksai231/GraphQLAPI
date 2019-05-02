using GraphQl.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace GraphQl.Api.Data
{
    public class DataContext : DbContext
    {
     public DataContext(DbContextOptions<DataContext> options) : base(options)
     {
     }

     public DbSet<User> Users { get; set; }   

     public DbSet<Vehicle> Vehicles { get; set; }   
    }
}