using Core.Entities;
using System;

namespace Entities.Concrete
{
    public class Product : IEntity
    {
        public Product()
        {
            CreatedAt = DateTime.Now;
        }
        public int Id { get; set; }
        public int UnitId { get; set; }
        public int CategoryId { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsActive { get; set; }
        public int Discount { get; set; }
        public string ProductInfo { get; set; }

    }
}
