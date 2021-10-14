using Business.Abstract;
using Core.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class DayManager : IDayService
    {
        public IResult Add(Day day)
        {
            throw new NotImplementedException();

        }

        public IDataResult<List<Day>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<Day> GetById(int dayId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Day>> GetDayOfMonth(int monthId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Day>> GetDayOfWeek(int weekId)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Day day)
        {
            throw new NotImplementedException();
        }
    }
}
