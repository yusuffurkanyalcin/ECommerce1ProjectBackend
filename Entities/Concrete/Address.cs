using Core.Entities;


namespace Entities.Concrete
{
    public class Address : IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int CityId { get; set; }
        public int TownId { get; set; }
        public string PostalCode { get; set; }
        public string AddressInfo { get; set; }
    }
}
