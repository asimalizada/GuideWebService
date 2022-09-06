using Core.Aspects.Autofac.Caching;
using Core.Business.Concrete;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using Guide.Business.Abstract;
using Guide.Business.Constants;
using Guide.Business.ValidationRules.FluentValidation;
using Guide.DataAccess.Abstract;
using Guide.Entities.Concrete.Exercises;
using Guide.Entities.Constants;
using Guide.Entities.Models.Exercises;

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

        //[CacheAspect]
        //public IDataResult<List<ExerciseModel>> GetDailyTasks()
        //{
        //    return new SuccessDataResult<List<ExerciseModel>>(_exerciseDal.GetExerciseDetails(t => t.TimeCategoryId == ExerciseTimeCategory.Daily), Messages.DataFound);
        //}

        //[CacheAspect]
        //public IDataResult<List<ExerciseModel>> GetDailyToDoTasks()
        //{
        //    return new SuccessDataResult<List<ExerciseModel>>(_exerciseDal.GetExerciseToDoDetails(t => t.TimeCategoryId == ExerciseTimeCategory.Daily), Messages.DataFound);
        //}

        //[CacheAspect]
        //public IDataResult<List<ExerciseModel>> GetMonthlyTasks()
        //{
        //    return new SuccessDataResult<List<ExerciseModel>>(_exerciseDal.GetExerciseDetails(t => t.TimeCategoryId == ExerciseTimeCategory.Monthly), Messages.DataFound);
        //}

        //[CacheAspect]
        //public IDataResult<List<ExerciseModel>> GetMonthlyToDoTasks()
        //{
        //    return new SuccessDataResult<List<ExerciseModel>>(_exerciseDal.GetExerciseToDoDetails(t => t.TimeCategoryId == ExerciseTimeCategory.Monthly), Messages.DataFound);
        //}

        //[CacheAspect]
        //public IDataResult<List<ExerciseModel>> GetTaskDetails()
        //{
        //    return new SuccessDataResult<List<ExerciseModel>>(_exerciseDal.GetExerciseDetails(), Messages.DataFound);
        //}

        //[CacheAspect]
        //public IDataResult<List<ExerciseModel>> GetTaskToDoDetails()
        //{
        //    return new SuccessDataResult<List<ExerciseModel>>(_exerciseDal.GetExerciseToDoDetails(), Messages.DataFound);
        //}

        //[CacheAspect]
        //public IDataResult<List<ExerciseModel>> GetWeeklyTasks()
        //{
        //    return new SuccessDataResult<List<ExerciseModel>>(_exerciseDal.GetExerciseDetails(t => t.TimeCategoryId == ExerciseTimeCategory.Weekly), Messages.DataFound);
        //}

        //[CacheAspect]
        //public IDataResult<List<ExerciseModel>> GetWeeklyToDoTasks()
        //{
        //    return new SuccessDataResult<List<ExerciseModel>>(_exerciseDal.GetExerciseToDoDetails(t => t.TimeCategoryId == ExerciseTimeCategory.Weekly), Messages.DataFound);
        //}
    }
}
