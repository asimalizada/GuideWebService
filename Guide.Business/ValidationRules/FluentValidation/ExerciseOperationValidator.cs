using FluentValidation;
using Guide.Entities.Concrete.Exercises;

namespace Guide.Business.ValidationRules.FluentValidation
{
    public class ExerciseOperationValidator : AbstractValidator<ExerciseOperation>
    {
        public ExerciseOperationValidator()
        {
            RuleFor(e => e.Id).NotNull();
            RuleFor(e => e.CompleteDate).NotNull();
            RuleFor(e => e.ExerciseId).NotNull();
            RuleFor(e => e.ExerciseId).GreaterThan(0);
        }
    }
}
