using Core.Business.Concrete;
using Guide.Business.Abstract;
using Guide.Business.ValidationRules.FluentValidation;
using Guide.DataAccess.Abstract;
using Guide.Entities.Concrete.Exercises;

namespace Guide.Business.Concrete
{
    public class ExerciseManager : ManagerRepositoryBase<Exercise, IExerciseRepository>, IExerciseService
    {
        private readonly IExerciseRepository _exerciseRepository;

        public ExerciseManager(IExerciseRepository repository) : base(repository)
        {
            _exerciseRepository = repository;
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
