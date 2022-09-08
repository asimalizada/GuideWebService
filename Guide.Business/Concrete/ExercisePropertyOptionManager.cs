using Core.Business.Concrete;
using Guide.Business.Abstract;
using Guide.Business.ValidationRules.FluentValidation;
using Guide.DataAccess.Abstract;
using Guide.Entities.Concrete.Exercises;

namespace Guide.Business.Concrete
{
    public class ExercisePropertyOptionManager : ManagerRepositoryBase<ExercisePropertyOption, IExercisePropertyOptionRepository>, IExercisePropertyOptionService
    {
        public ExercisePropertyOptionManager(IExercisePropertyOptionRepository repository) : base(repository)
        {
            base.SetValidator(new ExercisePropertyOptionValidator());
        }
    }
}
