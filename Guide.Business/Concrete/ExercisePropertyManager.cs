using Core.Business.Concrete;
using Guide.Business.Abstract;
using Guide.Business.ValidationRules.FluentValidation;
using Guide.DataAccess.Abstract;
using Guide.Entities.Concrete.Exercises;

namespace Guide.Business.Concrete
{
    public class ExercisePropertyManager : ManagerRepositoryBase<ExerciseProperty, IExercisePropertyDal>, IExercisePropertyService
    {
        public ExercisePropertyManager(IExercisePropertyDal dal) : base(dal)
        {
            base.SetValidator(new ExercisePropertyValidator());
        }
    }
}
