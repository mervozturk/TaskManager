using Core.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ITaskService
    {
        IDataResult<List<Task>> GetAll(); 
        IDataResult<List<Task>> GetAllTaskOfDay(Day day);
        IDataResult<List<Task>> GetAllTaskOfWeek(int weekId);
        IDataResult<List<Task>> GetAllTaskOfMonth(Month month);
        IDataResult<Task> GetById(int taskId);
        IResult Add(Task task);
        IResult Update(Task task);
    }
}
