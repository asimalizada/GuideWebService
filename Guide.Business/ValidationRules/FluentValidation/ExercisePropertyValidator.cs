using FluentValidation;
using Guide.Entities.Concrete.Exercises;

namespace Guide.Business.ValidationRules.FluentValidation
{
    public class ExercisePropertyValidator : AbstractValidator<ExerciseProperty>
    {
        public ExercisePropertyValidator()
        {
            RuleFor(e => e.Id).NotNull();
            RuleFor(e => e.Name).NotNull();
            RuleFor(e => e.Name).MinimumLength(1);
            RuleFor(a => a.Type).NotNull();
        }
    }
}
