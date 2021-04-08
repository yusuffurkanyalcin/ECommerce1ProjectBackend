using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IFavoriteService
    {
        IDataResult<Favorite> Get(int userId);
        IResult Add(Favorite favorite);
        IResult Delete(Favorite favorite);
    }
}
