using Core.Business.Abstract;
using Guide.Entities.Concrete.Exercises;

namespace Guide.Business.Abstract
{
    public interface IExerciseService : IServiceRepository<Exercise>
    {
        //IDataResult<List<ExerciseModel>> GetTaskDetails();
        //IDataResult<List<ExerciseModel>> GetDailyTasks();
        //IDataResult<List<ExerciseModel>> GetWeeklyTasks();
        //IDataResult<List<ExerciseModel>> GetMonthlyTasks();
        //IDataResult<List<ExerciseModel>> GetTaskToDoDetails();
        //IDataResult<List<ExerciseModel>> GetDailyToDoTasks();
        //IDataResult<List<ExerciseModel>> GetWeeklyToDoTasks();
        //IDataResult<List<ExerciseModel>> GetMonthlyToDoTasks();
    }
}
