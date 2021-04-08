using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface ICityService
    {
        IDataResult<List<City>> GetAll();
        IDataResult<City> Get(int cityId);
        IResult Add(City city);
        IResult Delete(City city);
        IResult Update(City city);

    }
}
