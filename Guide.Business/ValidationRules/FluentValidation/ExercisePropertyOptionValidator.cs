using FluentValidation;
using Guide.Entities.Concrete.Exercises;

namespace Guide.Business.ValidationRules.FluentValidation
{
    public class ExercisePropertyOptionValidator : AbstractValidator<ExercisePropertyOption>
    {
        public ExercisePropertyOptionValidator()
        {
            RuleFor(e => e.Id).NotNull();
            RuleFor(e => e.Name).NotNull();
            RuleFor(e => e.Name).MinimumLength(1);
            RuleFor(e => e.ExercisePropertyId).NotNull();
            RuleFor(e => e.ExercisePropertyId).GreaterThan(0);
        }
    }
}
