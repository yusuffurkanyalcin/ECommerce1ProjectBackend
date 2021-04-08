using Business.Abstract;
using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class UnitManager : IUnitService
    {
        public IResult Add(Unit unit)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(Unit unit)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Unit> Get(int unitId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Unit>> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
