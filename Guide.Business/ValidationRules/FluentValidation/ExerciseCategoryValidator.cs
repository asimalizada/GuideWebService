using FluentValidation;
using Guide.Entities.Concrete;

namespace Guide.Business.ValidationRules.FluentValidation
{
    public class ExerciseCategoryValidator : AbstractValidator<ExerciseCategory>
    {
        public ExerciseCategoryValidator()
        {
            RuleFor(e => e.Id).NotEmpty();
            RuleFor(e => e.Name).NotEmpty();
            RuleFor(e => e.Name).MinimumLength(1);
        }
    }
}
