using Business.Abstract;
using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class OrderManager : IOrderService
    {
        public IResult Add(Order order)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(Order order)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Order> Get(int orderId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Order>> GetAllByUserId(int userId)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Order order)
        {
            throw new NotImplementedException();
        }
    }
}
