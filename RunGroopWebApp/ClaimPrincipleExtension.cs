using System.Security.Claims;

namespace RunGroopWebApp
{
    public static class ClaimPrincipleExtension
    {
        public static string GetUserId(this ClaimsPrincipal user)
        {
            return user.FindFirst(ClaimTypes.NameIdentifier).Value;

        }
    }
}
