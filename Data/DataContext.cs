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
        public DbSet<Manager> Managers { get; set; }
        public DbSet<ManagerType> ManagerTypes { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<ReviewCategory> ReviewCategories { get; set; }
        public DbSet<ReviewImage> ReviewImages { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<RoomReservation> RoomReservations { get; set; }
        public DbSet<RoomType> RoomTypes { get; set; }
        public DbSet<RoomStatus> RoomStatuses { get; set; }
        public DbSet<RoomImage> RoomImages { get; set; }
        public DbSet<RoomRecepsionist> RoomRecepsionists { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)  //lidhjet bohen qetu one to many
        {
            // base.OnModelCreating(modelBuilder) 
            // User ↔ Role
            modelBuilder.Entity<User>()
                .HasOne(u => u.Role)
                .WithMany(r => r.Users)
                .HasForeignKey(u => u.RoleID)
                .OnDelete(DeleteBehavior.Cascade);

            //Manager ↔ User
            modelBuilder.Entity<User>()
          .HasOne(u => u.Manager)
          .WithOne(m => m.User)
          .HasForeignKey<Manager>(m => m.UserID)
          .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Manager>()
                .HasOne(m => m.ManagerType)
                .WithMany(mt => mt.Managers)
                .HasForeignKey(m => m.ManagerTypeID)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<ManagerType>()
                .Property(mt => mt.Name)
                .IsRequired()
                .HasMaxLength(50);

        }
    }
}
