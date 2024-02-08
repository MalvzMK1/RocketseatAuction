using System.ComponentModel.DataAnnotations.Schema;

namespace RocketseatAuction.Api.Entities
{
    [Table("Offers")]
    public class Offer
    {
        public int Id { get; set; }
        public DateTime CreatedOn { get; set; } = DateTime.Now;
        public float Price { get; set; }
        public int ItemId { get; set; }
        public int UserId { get; set; }
    }
}
