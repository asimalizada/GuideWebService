using Core.Aspects.Autofac.Caching;
using Core.Business.Abstract;
using Core.Business.Concrete;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using Guide.Business.Abstract;
using Guide.Business.Constants;
using Guide.Business.ValidationRules.FluentValidation;
using Guide.DataAccess.Abstract;
using Guide.Entities.Concrete.Exercises;

namespace Guide.Business.Concrete
{
    public class ExerciseOperationManager : ManagerRepositoryBase<ExerciseOperation, IExerciseOperationDal>, IExerciseOperationService
    {
        private readonly IExerciseOperationDal _exerciseOperationDal;

        public ExerciseOperationManager(IExerciseOperationDal dal) : base(dal)
        {
            _exerciseOperationDal = dal;
            base.SetValidator(new ExerciseOperationValidator());
        }

        [CacheAspect]
        public IDataResult<List<ExerciseOperation>> GetByDate(DateTime date)
        {
            return new SuccessDataResult<List<ExerciseOperation>>(_exerciseOperationDal.GetAll(t => t.CompleteDate == date), Messages.DataFound);
        }

        [CacheAspect]
        public IDataResult<List<ExerciseOperation>> GetByDate(DateTime from, DateTime to)
        {
            return new SuccessDataResult<List<ExerciseOperation>>(_exerciseOperationDal.GetAll(t => t.CompleteDate >= from & t.CompleteDate <= to), Messages.DataFound);
        }
    }
}
