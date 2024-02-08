using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using RocketseatAuction.Api.Repositories;

namespace RocketseatAuction.Api.Filters
{
    public class AuthenticationUserAttribute : AuthorizeAttribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            try
            {
                RocketseatAuctionDbContext repository = new RocketseatAuctionDbContext();

                string token = GetTokenOnRequest(context.HttpContext);

                string email = FromBase64String(token);

                bool exist = repository.Users.Any(user => user.Email == email);

                if (!exist)
                    context.Result = new UnauthorizedObjectResult("Invalid access token");
            }
            catch (Exception ex)
            {
                context.Result = new UnauthorizedObjectResult(ex.Message);
            }
        }

        private string GetTokenOnRequest(HttpContext context)
        {
            string authorization = context.Request.Headers.Authorization.ToString();

            if (string.IsNullOrEmpty(authorization))
                throw new Exception("No authorization token was provided");

            if (authorization.Length < 7)
                throw new Exception("The provided authorization token is ivalid");

            return authorization["Bearer ".Length..];
        }

        private string FromBase64String(string base64)
        {
            byte[] data = Convert.FromBase64String(base64);

            return System.Text.Encoding.UTF8.GetString(data);
        }
    }
}
