using Core.Business.Concrete;
using Guide.Business.Abstract;
using Guide.Business.ValidationRules.FluentValidation;
using Guide.DataAccess.Abstract;
using Guide.Entities.Concrete.Exercises;

namespace Guide.Business.Concrete
{
    public class ExercisePropertyManager : ManagerRepositoryBase<ExerciseProperty, IExercisePropertyRepository>, IExercisePropertyService
    {
        public ExercisePropertyManager(IExercisePropertyRepository repository) : base(repository)
        {
            base.SetValidator(new ExercisePropertyValidator());
        }
    }
}
