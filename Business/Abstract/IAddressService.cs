using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IAddressService
    {
        IDataResult<List<Address>> GetAll();
        IDataResult<Address> Get(int userId);
        IResult Add(Address address);
        IResult Delete(Address address);
        IResult Update(Address address);
    }
}
