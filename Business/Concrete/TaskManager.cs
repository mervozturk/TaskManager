using Business.Abstract;
using Core.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class TaskManager : ITaskService
    {
        ITaskDal _taskDal;
        public TaskManager(ITaskDal taskDal)
        {
            _taskDal = taskDal;
        }
        public IResult Add(Tasks task) // yeni görev kaydeder
        {
            task.WeekId = FindWeekId(task.Date);
            task.MonthId = task.Date.Month;
            task.IsDone = false;
            _taskDal.Add(task);
            return new SuccessResult();
        }

        public IDataResult<List<Tasks>> GetAll() // Bütün görevleri getirir
        {
            return new SuccessDataResult<List<Tasks>>(_taskDal.GetAll());
        }

        public IDataResult<List<Tasks>> GetAllTaskOfDay(DateTime date)  // parametre olarak gelen tarihteki görevleri listeler
        {
            
            return new SuccessDataResult<List<Tasks>>(_taskDal.GetAll(t=>t.Date.Date == date.Date).ToList());
        }

        public IDataResult<List<Tasks>> GetAllTaskOfMonth(int monthId)  // parametre olarak gelen ayda ki görevleri listeler
        {
            return new SuccessDataResult<List<Tasks>>(_taskDal.GetAll(d => d.Date.Month == monthId));
        }

        public IDataResult<List<Tasks>> GetAllTaskOfWeek(DateTime date) // parametre olarak gelen haftada ki görevleri listeler
        {
            int weekId = FindWeekId(date);
            return new SuccessDataResult<List<Tasks>>(_taskDal.GetAll(d => d.WeekId==weekId));
        }

        public IDataResult<Tasks> GetById(int taskId) // parametre olarak gelen Id'nin verilerini getirir
        {
            return new SuccessDataResult<Tasks>(_taskDal.Get(t=>t.Id==taskId));
        }

        public IResult Update(Tasks task)  // görev güncelleme
        {
            task.WeekId = FindWeekId(task.Date);
            task.MonthId = task.Date.Month;
            _taskDal.Update(task);
            return new SuccessResult();
        }
        public int FindWeekId(DateTime date)  // Verilen tarihin yılın kaçıncı haftası olduğunu bulur.
        {
            DayOfWeek day = CultureInfo.InvariantCulture.Calendar.GetDayOfWeek(date);
            if (day >= DayOfWeek.Monday && day <= DayOfWeek.Wednesday)
            {
                date = date.AddDays(3);
            }
            return CultureInfo.InvariantCulture.Calendar.GetWeekOfYear(date, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);

        }

        public IResult Delete(int Id) // verilen Id'deki nesneyi siler
        {
            _taskDal.Delete(new Tasks { Id = Id });
            return new SuccessResult();
        }
    }
}
