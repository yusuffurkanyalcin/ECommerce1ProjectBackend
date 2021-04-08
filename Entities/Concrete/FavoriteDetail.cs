using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class FavoriteDetail:IEntity
    {
        public int Id { get; set; }
        public int FavoriteId { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public int ProductDiscount { get; set; }
    }
}
