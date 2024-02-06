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

            if (string.IsNullOrEmpty(authorization))
                throw new Exception("No authorization token was provided");

            if (authorization.Length < 7)
                throw new Exception("The provided authorization token is ivalid");

            return authorization["Bearer ".Length..];
        }
    }
}
