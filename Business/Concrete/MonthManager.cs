using Business.Abstract;
using Core.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class MonthManager : IMonthService
    {
        public IResult Add(Month month)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Month>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<Month> GetById(int monthId)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Month month)
        {
            throw new NotImplementedException();
        }
    }
}
