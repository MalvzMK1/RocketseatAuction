using RocketseatAuction.Api.Entities;

namespace RocketseatAuction.Api.UseCases.Items.Get
{
    public class GetItemUseCase : UseCasesBase
    {
        public Item? Execute(int itemId)
        {
            return repository
                .Items
                .FirstOrDefault(item => item.Id == itemId);
        }
    }
}
