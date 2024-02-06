namespace RocketseatAuction.Communication.Requests
{
    public class RequestCreateOfferJson
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public float Price { get; set; }
    }
}
