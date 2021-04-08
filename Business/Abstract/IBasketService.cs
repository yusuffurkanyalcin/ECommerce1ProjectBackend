using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IBasketService
    {
        IDataResult<Basket> Get(int userId);
        IResult Add(Basket basket);
        IResult Delete(Basket basket);
    }
}
