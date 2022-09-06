using Core.Business.Concrete;
using Guide.Business.Abstract;
using Guide.Business.ValidationRules.FluentValidation;
using Guide.DataAccess.Abstract;
using Guide.Entities.Concrete.Exercises;

namespace Guide.Business.Concrete
{
    public class ExercisePropertyOptionManager : ManagerRepositoryBase<ExercisePropertyOption, IExercisePropertyOptionDal>, IExercisePropertyOptionService
    {
        public ExercisePropertyOptionManager(IExercisePropertyOptionDal dal) : base(dal)
        {
            base.SetValidator(new ExercisePropertyOptionValidator());
        }
    }
}
