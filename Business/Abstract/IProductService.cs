using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IProductService
    {
        IDataResult<List<Product>> GetAll();
        IDataResult<Product> Get(int productId);
        IDataResult<List<Product>> GetByCategoryId(int categoryId);
        IDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max);
        IResult Add(Product product);
        IResult Delete(Product product);
        IResult Update(Product product);
        IResult AddTransactionalTest(Product product);
    }
}
