using Core.DataAccess.Abstract;
using Guide.Entities.Concrete.Exercises;
using Guide.Entities.Models;
using Guide.Entities.Models.Exercises;
using System.Linq.Expressions;

namespace Guide.DataAccess.Abstract
{
    public interface IExerciseDal : IEntityRepository<Exercise>
    {
        //List<ExerciseModel> GetExerciseDetails(Expression<Func<Exercise, bool>> filter = null);
        //List<ExerciseModel> GetExerciseToDoDetails(Expression<Func<Exercise, bool>> filter = null);
        //double GetDailyReport(DateTime date);
        //WeeklyReport GetWeeklyReport(DateTime begin, DateTime end);
        //List<Exercise> GetDailyExercises(DateTime date);
        //List<Exercise> GetDailyCompletedExercises(DateTime begin);
        //List<Exercise> GetExercisesForDate(DateTime begin, DateTime end);
        //List<Exercise> GetCompletedExercisesForDate(DateTime begin, DateTime end);
    }
}
