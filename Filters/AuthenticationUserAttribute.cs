using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Filters;

namespace RocketseatAuction.Filters
{
    public class AuthenticationUserAttribute : AuthorizeAttribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            string token = GetTokenOnRequest(context.HttpContext);
        }

        private string GetTokenOnRequest(HttpContext context)
        {
            var authorization = context.Request.Headers.Authorization.ToString();

            return authorization["Bearer ".Length..];
        }
    }
}
