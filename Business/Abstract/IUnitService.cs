using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IUnitService
    {
        IDataResult<List<Unit>> GetAll();
        IDataResult<Unit> Get(int unitId);
        IResult Add(Unit unit);
        IResult Delete(Unit unit);
    }
}
