using PartyRaidR.Shared.Dtos;
using PartyRaidR.Shared.Models.Responses;

namespace PartyRaidR.Backend.Services.Promises
{
    public interface IAuthenticationService
    {
        Task<ServiceResponse<UserDto>> RegisterAsync(UserRegistrationDto user);
        Task<ServiceResponse<string>> LoginAsync(UserLoginDto user);
    }
}
