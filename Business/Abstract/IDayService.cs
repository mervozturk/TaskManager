using Core.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IDayService
    {
        IDataResult<List<Day>> GetAll();
        IDataResult<List<Day>> GetDayOfWeek(int weekId);
        IDataResult<List<Day>> GetDayOfMonth(int monthId);
        IDataResult<Day> GetById(int dayId);
        IResult Add(Day day);
        IResult Update(Day day);

    }
}
