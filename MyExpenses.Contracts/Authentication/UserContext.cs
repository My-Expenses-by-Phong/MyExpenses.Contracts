using Microsoft.AspNetCore.Http;
using System.Security.Claims;

namespace MyExpenses.Contracts.Authentication
{
    public class UserContext(IHttpContextAccessor httpContextAccessor) : IUserContext
    {
        private readonly IHttpContextAccessor _httpContextAccessor = httpContextAccessor;

        public Guid GetCurrentUserId()
        {
            string? userId = _httpContextAccessor.HttpContext?.User?.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            return userId is null ? Guid.Empty : Guid.Parse(userId);
        }
    }
}
