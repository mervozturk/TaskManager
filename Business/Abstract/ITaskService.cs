using Core.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ITaskService
    {
        // Tasks için yazılacak fonksiyonlar listesi
        IDataResult<List<Tasks>> GetAll(); 
        IDataResult<List<Tasks>> GetAllTaskOfDay(DateTime date);
        IDataResult<List<Tasks>> GetAllTaskOfWeek(DateTime date);
        IDataResult<List<Tasks>> GetAllTaskOfMonth(int monthId);
        IDataResult<Tasks> GetById(int taskId);
        IResult Add(Tasks task);
        IResult Update(Tasks task);
        IResult Delete(int Id);
    }
}
