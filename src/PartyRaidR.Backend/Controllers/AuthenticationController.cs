using Microsoft.AspNetCore.Mvc;
using PartyRaidR.Backend.Services;
using PartyRaidR.Backend.Services.Promises;
using PartyRaidR.Shared.Dtos.AuthenticationRequests;

namespace PartyRaidR.Backend.Controllers
{
    [Controller]
    [Route("api/[controller]")]
    public class AuthenticationController : ControllerBase
    {
        private readonly IAuthenticationService _service;

        public AuthenticationController(AuthenticationService authService)
        {
            _service = authService;
        }

        [HttpGet("register")]
        public async Task<object> RegisterAsync(UserRegistrationDto newUser)
        {
            var result = await _service.RegisterAsync(newUser);

            if (result.Success)
                return Ok(result);

            return StatusCode(result.StatusCode, result);
        }
    }
}
