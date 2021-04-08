using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface ITownService
    {
        IDataResult<List<Town>> GetAll();
        IDataResult<Town> Get(int townId);
        IDataResult<List<Town>> GetByCityId(int cityId);
        IResult Add(Town town);
        IResult Delete(Town town);
        IResult Update(Town town);
    }
}
