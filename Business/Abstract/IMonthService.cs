using Core.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IMonthService
    {
        IDataResult<List<Month>> GetAll();
        IDataResult<Month> GetById(int monthId);
        IResult Add(Month month);
        IResult Update(Month month);

    }
}
