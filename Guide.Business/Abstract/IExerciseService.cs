using Core.Business.Abstract;
using Core.Utilities.Results.Abstract;
using Guide.Entities.Concrete;
using Guide.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guide.Business.Abstract
{
    public interface IExerciseService : IServiceRepository<Exercise>
    {
        IDataResult<List<ExerciseDetail>> GetTaskDetails();
        IDataResult<List<ExerciseDetail>> GetDailyTasks();
        IDataResult<List<ExerciseDetail>> GetWeeklyTasks();
        IDataResult<List<ExerciseDetail>> GetMonthlyTasks();
        IDataResult<List<ExerciseDetail>> GetTaskToDoDetails();
        IDataResult<List<ExerciseDetail>> GetDailyToDoTasks();
        IDataResult<List<ExerciseDetail>> GetWeeklyToDoTasks();
        IDataResult<List<ExerciseDetail>> GetMonthlyToDoTasks();
    }
}
