using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;

namespace INTERNET_SHOP.SystemClasses
{
    public class CustomAuthenticationStateProvider : AuthenticationStateProvider
    {
            public override Task<AuthenticationState> GetAuthenticationStateAsync()
            {
                var identity = new ClaimsIdentity(new[]
                {
            new Claim(ClaimTypes.Name, "testUser"),
            }, "TestUser authentication type");
                var user = new ClaimsPrincipal(identity);
                return Task.FromResult(new AuthenticationState(user));
            }
    }
}
