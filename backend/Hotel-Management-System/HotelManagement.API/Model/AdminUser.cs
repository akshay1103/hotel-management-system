namespace HotelManagement.API.Model
{
    public class AdminUser
    {
        public int Id { get; set; }
        // Primary key. Unique identifier for each admin.

        public string Username { get; set; }
        // Used to log in to the system. Should be unique.

        public string PasswordHash { get; set; }
        // Stores a hashed version of the password for security.

        public string FullName { get; set; }
        // Admin's full name for display and records.

        public string Email { get; set; }
        // Used for communication, alerts, password reset, etc.

        public string PhoneNumber { get; set; }
        // Optional - may be used for contact or OTP.

        public bool IsActive { get; set; }
        // Marks if the admin account is currently enabled or disabled.

        public string Role { get; set; }
        // Role or permission level, like "SuperAdmin", "Manager", etc.

        public DateTime CreatedAt { get; set; }
        // When the admin account was created.

        public DateTime? LastLoginAt { get; set; }
        // Timestamp of last login. Helpful for tracking usage.

        public string? ProfileImageUrl { get; set; }
        // Optional: URL or path to profile picture.
    }

    public class AdminUserDto
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsActive { get; set; }
        public string Role { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? LastLoginAt { get; set; }
        public string? ProfileImageUrl { get; set; }
    }


}
