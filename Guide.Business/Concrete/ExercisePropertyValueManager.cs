using Core.Business.Concrete;
using Guide.Business.Abstract;
using Guide.Business.ValidationRules.FluentValidation;
using Guide.DataAccess.Abstract;
using Guide.Entities.Concrete.Exercises;

namespace Guide.Business.Concrete
{
    public class ExercisePropertyValueManager : ManagerRepositoryBase<ExercisePropertyValue, IExercisePropertyValueDal>, IExercisePropertyValueService
    {
        public ExercisePropertyValueManager(IExercisePropertyValueDal dal) : base(dal)
        {
            base.SetValidator(new ExercisePropertyValueValidator());
        }
    }
}
