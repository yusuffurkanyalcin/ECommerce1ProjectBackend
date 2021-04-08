using Business.Abstract;
using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class TownManager : ITownService
    {
        public IResult Add(Town town)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(Town town)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Town> Get(int townId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Town>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Town>> GetByCityId(int cityId)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Town town)
        {
            throw new NotImplementedException();
        }
    }
}
