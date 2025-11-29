using HotelMgm.Models;
using Microsoft.EntityFrameworkCore;


namespace HotelMgm.Data
{
    public class DataContext :DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)  //lidhjet bohen qetu one to many
        {
           // base.OnModelCreating(modelBuilder) 
           
        }
    }
}
