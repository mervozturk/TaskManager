using Business.Abstract;
using Core.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class TaskManager : ITaskService
    {
        public IResult Add(Task task)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Task>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Task>> GetAllTaskOfDay(Day day)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Task>> GetAllTaskOfMonth(Month month)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Task>> GetAllTaskOfWeek(int weekId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Task> GetById(int taskId)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Task task)
        {
            throw new NotImplementedException();
        }
    }
}
