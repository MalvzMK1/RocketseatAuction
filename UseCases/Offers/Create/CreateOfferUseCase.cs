using RocketseatAuction.Api.Communication.Requests;
using RocketseatAuction.Api.Entities;
using RocketseatAuction.Api.Services;

namespace RocketseatAuction.Api.UseCases.Offers.Create
{
    public class CreateOfferUseCase : UseCasesBase
    {
        private readonly LoggedUser _loggedUser;
        
        public CreateOfferUseCase(LoggedUser loggedUser) => _loggedUser = loggedUser;

        public void Execute(int itemId, RequestCreateOfferJson request)
        {
            User user = _loggedUser.User();

            Offer offer = new Offer()
            {
                CreatedOn = DateTime.Now,
                ItemId = itemId,
                Price = request.Price,
                UserId = user.Id,
            };
            
            repository.Offers.Add(offer);

            // É preciso salvar para que realmente seja salvo no banco de dados
            repository.SaveChanges();
        }
    }
}
