using FluentValidation;
using Guide.Entities.Concrete;

namespace Guide.Business.ValidationRules.FluentValidation
{
    public class ExerciseCategoryValidator : AbstractValidator<ExerciseCategory>
    {
        public ExerciseCategoryValidator()
        {

        }
    }
}
