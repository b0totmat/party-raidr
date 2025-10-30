namespace PartyRaidR.Shared.Models
{
    public class User : IDbEntity<User>
    {
        public User()
        {
            Id = Guid.Empty.ToString();
            Username = string.Empty;
            Email = string.Empty;
            PasswordHash = string.Empty;
            ProfilePictureUrl = string.Empty;
            RegisterDate = DateTime.Now;
            RoleId = string.Empty;
            CityId = string.Empty;
        }

        public User(Guid id, string username, string email, string passwordHash, string profilePictureUrl, DateTime registerDate, string roleId, string cityId)
        {
            Id = id.ToString();
            Username = username;
            Email = email;
            PasswordHash = passwordHash;
            ProfilePictureUrl = profilePictureUrl;
            RegisterDate = registerDate;
            RoleId = roleId;
            CityId = cityId;
        }

        public string Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string ProfilePictureUrl { get; set; }
        public DateTime RegisterDate { get; set; }
        public string RoleId { get; set; }
        public string CityId { get; set; }
    }
}
