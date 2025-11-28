namespace PartyRaidR.Shared.Dtos.AuthenticationRequests
{
    public class UserRegistrationDto : UserDto
    {
        public string PasswordHash { get; set; } = string.Empty;
    }
}
