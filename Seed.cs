using HotelMgm.Data;
using HotelMgm.Models;
using System.Security.Cryptography;
using System.Text;

namespace HotelMgm
{
    public class Seed
    {
        private readonly DataContext dataContext;

        public Seed(DataContext context)
        {
            this.dataContext = context;
        }

        private void CreatePasswordHash(string password, out byte[] hash, out byte[] salt)
        {
            using (var hmac = new HMACSHA512())
            {
                salt = hmac.Key;
                hash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
            }
        }

        public void SeedDataContext()
        {
            // Seed Roles
            if (!dataContext.Roles.Any())
            {
                var roles = new List<Role>
            {
                new Role() { RoleType = "Admin" },
                new Role() { RoleType = "RoomManager" },
                //new Role() { RoleType = "ServiceManager" },
                new Role() { RoleType = "Customer" }
            };

                dataContext.Roles.AddRange(roles);
                dataContext.SaveChanges();
            }

            // Seed Users
            if (!dataContext.Users.Any())
            {
                var adminRoleID = dataContext.Roles.First(r => r.RoleType == "Admin").RoleID;
                var roomManagerRoleID = dataContext.Roles.First(r => r.RoleType == "RoomManager").RoleID;
               // var serviceManagerRoleID = dataContext.Roles.First(r => r.RoleType == "ServiceManager").RoleID;
                var customerRoleID = dataContext.Roles.First(r => r.RoleType == "Customer").RoleID;

                CreatePasswordHash("Ruvejda123", out var adminHash, out var adminSalt);
                CreatePasswordHash("Liranda123", out var roomManagerHash, out var roomManagerSalt); 
               // CreatePasswordHash("Rona123", out var serviceManagerHash, out var serviceManagerSalt);
                CreatePasswordHash("Erza123", out var customerHash, out var customerSalt);

                var users = new List<User>
            {
                new User() {
                    FirstName = "Orgesa", LastName = "Berisha", Email = "orgesa@gmail.com",
                    PasswordHash = adminHash, PasswordSalt = adminSalt,
                    Phone = "044-111-222", CreatedAt = DateTime.Now,
                    RoleID = adminRoleID
                },
                new User() {
                    FirstName = "Anesa", LastName = "Mecinaj", Email = "anesa@gmail.com",
                    PasswordHash = roomManagerHash, PasswordSalt = roomManagerSalt,
                    Address = "Prishtina", CreatedAt = DateTime.Now,
                    RoleID = roomManagerRoleID
                },
                
                //new User() {
                //    FirstName = "Anita", LastName = "Osmani", Email = "anita@gmail.com",
                //    PasswordHash = serviceManagerHash, PasswordSalt = serviceManagerSalt,
                //    CreatedAt = DateTime.Now, RoleID = serviceManagerRoleID
                //},
                
                new User() {
                    FirstName = "Festa", LastName = "Thaqi", Email = "festa@gmail.com",
                    PasswordHash = customerHash, PasswordSalt = customerSalt,
                    CreatedAt = DateTime.Now, RoleID = customerRoleID
                }
            };

                dataContext.Users.AddRange(users);
                dataContext.SaveChanges();
            }










        }
    }
}