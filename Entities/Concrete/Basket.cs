using Core.Entities;

namespace Entities.Concrete
{
    public class Basket : IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
    }
}
