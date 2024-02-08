using RocketseatAuction.Api.Entities;
using RocketseatAuction.Api.Repositories;

namespace RocketseatAuction.Api.Services
{
    public class LoggedUser
    {
        private readonly RocketseatAuctionDbContext _rocketseatAuctionDbContext = new RocketseatAuctionDbContext();
        private readonly IHttpContextAccessor _httpContextAccessor;

        public LoggedUser(IHttpContextAccessor httpContext)
        {
            _httpContextAccessor = httpContext;
        }

        public User User()
        {
            string token = GetTokenOnRequest();
            string email = FromBase64String(token);

            return _rocketseatAuctionDbContext.Users.First(user => user.Email.Equals(email));
        }

        private string GetTokenOnRequest()
        {
            string authorization = _httpContextAccessor.HttpContext!.Request.Headers.Authorization.ToString();

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
