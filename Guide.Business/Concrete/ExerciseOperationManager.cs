using Core.Aspects.Autofac.Caching;
using Core.Business.Concrete;
using Core.Features.Results.Abstract;
using Core.Features.Results.Concrete;
using Guide.Business.Abstract;
using Guide.Business.Constants;
using Guide.Business.ValidationRules.FluentValidation;
using Guide.DataAccess.Abstract;
using Guide.Entities.Concrete.Exercises;

namespace Guide.Business.Concrete
{
    public class ExerciseOperationManager : ManagerRepositoryBase<ExerciseOperation, IExerciseOperationRepository>, IExerciseOperationService
    {
        private readonly IExerciseOperationRepository _exerciseOperationRepository;

        public ExerciseOperationManager(IExerciseOperationRepository repository) : base(repository)
        {
            _exerciseOperationRepository = repository;
            base.SetValidator(new ExerciseOperationValidator());
        }

        [CacheAspect]
        public IDataResult<List<ExerciseOperation>> GetByDate(DateTime date)
        {
            return new SuccessDataResult<List<ExerciseOperation>>(_exerciseOperationRepository.GetAll(t => t.CompleteDate == date), Messages.DataFound);
        }

        [CacheAspect]
        public IDataResult<List<ExerciseOperation>> GetByDate(DateTime from, DateTime to)
        {
            return new SuccessDataResult<List<ExerciseOperation>>(_exerciseOperationRepository.GetAll(t => t.CompleteDate >= from & t.CompleteDate <= to), Messages.DataFound);
        }
    }
}
