using HotelManagement.API.Model;
using Microsoft.EntityFrameworkCore;

namespace HotelManagement.API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {

        }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<AdminUser>().HasData(
         new AdminUser { Id = 1, Username = "admin1", PasswordHash = "hashed_password_1", FullName = "Admin User 1", Email = "admin1@example.com", PhoneNumber = "1234567801", IsActive = true, Role = "SuperAdmin", CreatedAt = new DateTime(2024, 01, 01), LastLoginAt = new DateTime(2024, 01, 02), ProfileImageUrl = null },
         new AdminUser { Id = 2, Username = "admin2", PasswordHash = "hashed_password_2", FullName = "Admin User 2", Email = "admin2@example.com", PhoneNumber = "1234567802", IsActive = true, Role = "Manager", CreatedAt = new DateTime(2024, 01, 02), LastLoginAt = new DateTime(2024, 01, 03), ProfileImageUrl = null },
         new AdminUser { Id = 3, Username = "admin3", PasswordHash = "hashed_password_3", FullName = "Admin User 3", Email = "admin3@example.com", PhoneNumber = "1234567803", IsActive = true, Role = "SuperAdmin", CreatedAt = new DateTime(2024, 01, 03), LastLoginAt = new DateTime(2024, 01, 04), ProfileImageUrl = null },
         new AdminUser { Id = 4, Username = "admin4", PasswordHash = "hashed_password_4", FullName = "Admin User 4", Email = "admin4@example.com", PhoneNumber = "1234567804", IsActive = true, Role = "Manager", CreatedAt = new DateTime(2024, 01, 04), LastLoginAt = new DateTime(2024, 01, 05), ProfileImageUrl = null },
         new AdminUser { Id = 5, Username = "admin5", PasswordHash = "hashed_password_5", FullName = "Admin User 5", Email = "admin5@example.com", PhoneNumber = "1234567805", IsActive = true, Role = "SuperAdmin", CreatedAt = new DateTime(2024, 01, 05), LastLoginAt = new DateTime(2024, 01, 06), ProfileImageUrl = null },
         new AdminUser { Id = 6, Username = "admin6", PasswordHash = "hashed_password_6", FullName = "Admin User 6", Email = "admin6@example.com", PhoneNumber = "1234567806", IsActive = true, Role = "Manager", CreatedAt = new DateTime(2024, 01, 06), LastLoginAt = new DateTime(2024, 01, 07), ProfileImageUrl = null },
         new AdminUser { Id = 7, Username = "admin7", PasswordHash = "hashed_password_7", FullName = "Admin User 7", Email = "admin7@example.com", PhoneNumber = "1234567807", IsActive = true, Role = "SuperAdmin", CreatedAt = new DateTime(2024, 01, 07), LastLoginAt = new DateTime(2024, 01, 08), ProfileImageUrl = null },
         new AdminUser { Id = 8, Username = "admin8", PasswordHash = "hashed_password_8", FullName = "Admin User 8", Email = "admin8@example.com", PhoneNumber = "1234567808", IsActive = true, Role = "Manager", CreatedAt = new DateTime(2024, 01, 08), LastLoginAt = new DateTime(2024, 01, 09), ProfileImageUrl = null },
         new AdminUser { Id = 9, Username = "admin9", PasswordHash = "hashed_password_9", FullName = "Admin User 9", Email = "admin9@example.com", PhoneNumber = "1234567809", IsActive = true, Role = "SuperAdmin", CreatedAt = new DateTime(2024, 01, 09), LastLoginAt = new DateTime(2024, 01, 10), ProfileImageUrl = null },
         new AdminUser { Id = 10, Username = "admin10", PasswordHash = "hashed_password_10", FullName = "Admin User 10", Email = "admin10@example.com", PhoneNumber = "1234567810", IsActive = true, Role = "Manager", CreatedAt = new DateTime(2024, 01, 10), LastLoginAt = new DateTime(2024, 01, 11), ProfileImageUrl = null },
         new AdminUser { Id = 11, Username = "admin11", PasswordHash = "hashed_password_11", FullName = "Admin User 11", Email = "admin11@example.com", PhoneNumber = "1234567811", IsActive = true, Role = "SuperAdmin", CreatedAt = new DateTime(2024, 01, 11), LastLoginAt = new DateTime(2024, 01, 12), ProfileImageUrl = null },
         new AdminUser { Id = 12, Username = "admin12", PasswordHash = "hashed_password_12", FullName = "Admin User 12", Email = "admin12@example.com", PhoneNumber = "1234567812", IsActive = true, Role = "Manager", CreatedAt = new DateTime(2024, 01, 12), LastLoginAt = new DateTime(2024, 01, 13), ProfileImageUrl = null },
         new AdminUser { Id = 13, Username = "admin13", PasswordHash = "hashed_password_13", FullName = "Admin User 13", Email = "admin13@example.com", PhoneNumber = "1234567813", IsActive = true, Role = "SuperAdmin", CreatedAt = new DateTime(2024, 01, 13), LastLoginAt = new DateTime(2024, 01, 14), ProfileImageUrl = null },
         new AdminUser { Id = 14, Username = "admin14", PasswordHash = "hashed_password_14", FullName = "Admin User 14", Email = "admin14@example.com", PhoneNumber = "1234567814", IsActive = true, Role = "Manager", CreatedAt = new DateTime(2024, 01, 14), LastLoginAt = new DateTime(2024, 01, 15), ProfileImageUrl = null },
         new AdminUser { Id = 15, Username = "admin15", PasswordHash = "hashed_password_15", FullName = "Admin User 15", Email = "admin15@example.com", PhoneNumber = "1234567815", IsActive = true, Role = "SuperAdmin", CreatedAt = new DateTime(2024, 01, 15), LastLoginAt = new DateTime(2024, 01, 16), ProfileImageUrl = null },
         new AdminUser { Id = 16, Username = "admin16", PasswordHash = "hashed_password_16", FullName = "Admin User 16", Email = "admin16@example.com", PhoneNumber = "1234567816", IsActive = true, Role = "Manager", CreatedAt = new DateTime(2024, 01, 16), LastLoginAt = new DateTime(2024, 01, 17), ProfileImageUrl = null },
         new AdminUser { Id = 17, Username = "admin17", PasswordHash = "hashed_password_17", FullName = "Admin User 17", Email = "admin17@example.com", PhoneNumber = "1234567817", IsActive = true, Role = "SuperAdmin", CreatedAt = new DateTime(2024, 01, 17), LastLoginAt = new DateTime(2024, 01, 18), ProfileImageUrl = null },
         new AdminUser { Id = 18, Username = "admin18", PasswordHash = "hashed_password_18", FullName = "Admin User 18", Email = "admin18@example.com", PhoneNumber = "1234567818", IsActive = true, Role = "Manager", CreatedAt = new DateTime(2024, 01, 18), LastLoginAt = new DateTime(2024, 01, 19), ProfileImageUrl = null },
         new AdminUser { Id = 19, Username = "admin19", PasswordHash = "hashed_password_19", FullName = "Admin User 19", Email = "admin19@example.com", PhoneNumber = "1234567819", IsActive = true, Role = "SuperAdmin", CreatedAt = new DateTime(2024, 01, 19), LastLoginAt = new DateTime(2024, 01, 20), ProfileImageUrl = null },
         new AdminUser { Id = 20, Username = "admin20", PasswordHash = "hashed_password_20", FullName = "Admin User 20", Email = "admin20@example.com", PhoneNumber = "1234567820", IsActive = true, Role = "Manager", CreatedAt = new DateTime(2024, 01, 20), LastLoginAt = new DateTime(2024, 01, 21), ProfileImageUrl = null }
     );

        }
        public DbSet<AdminUser> AdminUsers { get; set; }
    }
}

