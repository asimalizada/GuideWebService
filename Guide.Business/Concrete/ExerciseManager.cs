using Core.Business.Concrete;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using Guide.Business.Abstract;
using Guide.Business.Constants;
using Guide.Business.ValidationRules.FluentValidation;
using Guide.DataAccess.Abstract;
using Guide.Entities.Concrete;
using Guide.Entities.Constants;
using Guide.Entities.Models;

namespace Guide.Business.Concrete
{
    public class ExerciseManager : ManagerRepositoryBase<Exercise, IExerciseDal>, IExerciseService
    {
        private readonly IExerciseDal _exerciseDal;

        public ExerciseManager(IExerciseDal dal) : base(dal)
        {
            _exerciseDal = dal;
            base.SetValidator(new ExerciseValidator());
        }

        public IDataResult<List<ExerciseDetail>> GetDailyTasks()
        {
            return new SuccessDataResult<List<ExerciseDetail>>(_exerciseDal.GetExerciseDetails(t => t.TimeCategoryId == ExerciseTimeCategory.Daily), Messages.DataFound);
        }

        public IDataResult<List<ExerciseDetail>> GetDailyToDoTasks()
        {
            return new SuccessDataResult<List<ExerciseDetail>>(_exerciseDal.GetExerciseToDoDetails(t => t.TimeCategoryId == ExerciseTimeCategory.Daily), Messages.DataFound);
        }

        public IDataResult<List<ExerciseDetail>> GetMonthlyTasks()
        {
            return new SuccessDataResult<List<ExerciseDetail>>(_exerciseDal.GetExerciseDetails(t => t.TimeCategoryId == ExerciseTimeCategory.Monthly), Messages.DataFound);
        }

        public IDataResult<List<ExerciseDetail>> GetMonthlyToDoTasks()
        {
            return new SuccessDataResult<List<ExerciseDetail>>(_exerciseDal.GetExerciseToDoDetails(t => t.TimeCategoryId == ExerciseTimeCategory.Monthly), Messages.DataFound);
        }

        public IDataResult<List<ExerciseDetail>> GetTaskDetails()
        {
            return new SuccessDataResult<List<ExerciseDetail>>(_exerciseDal.GetExerciseDetails(), Messages.DataFound);
        }

        public IDataResult<List<ExerciseDetail>> GetTaskToDoDetails()
        {
            return new SuccessDataResult<List<ExerciseDetail>>(_exerciseDal.GetExerciseToDoDetails(), Messages.DataFound);
        }

        public IDataResult<List<ExerciseDetail>> GetWeeklyTasks()
        {
            return new SuccessDataResult<List<ExerciseDetail>>(_exerciseDal.GetExerciseDetails(t => t.TimeCategoryId == ExerciseTimeCategory.Weekly), Messages.DataFound);
        }

        public IDataResult<List<ExerciseDetail>> GetWeeklyToDoTasks()
        {
            return new SuccessDataResult<List<ExerciseDetail>>(_exerciseDal.GetExerciseToDoDetails(t => t.TimeCategoryId == ExerciseTimeCategory.Weekly), Messages.DataFound);
        }
    }
}
