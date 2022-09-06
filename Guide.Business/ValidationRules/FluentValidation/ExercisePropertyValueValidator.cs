using FluentValidation;
using Guide.Entities.Concrete.Exercises;

namespace Guide.Business.ValidationRules.FluentValidation
{
    public class ExercisePropertyValueValidator : AbstractValidator<ExercisePropertyValue>
    {
        public ExercisePropertyValueValidator()
        {
            RuleFor(e => e.Id).NotNull();
            RuleFor(e => e.Value).NotNull();
            RuleFor(e => e.Value).MinimumLength(1);
            RuleFor(e => e.ExerciseId).NotNull();
            RuleFor(e => e.ExerciseId).GreaterThan(0);
            RuleFor(e => e.PropertyId).NotNull();
            RuleFor(e => e.PropertyId).GreaterThan(0);
        }
    }
}
