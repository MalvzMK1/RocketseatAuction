using RocketseatAuction.Entities;

namespace RocketseatAuction.UseCases.Items.Get
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
