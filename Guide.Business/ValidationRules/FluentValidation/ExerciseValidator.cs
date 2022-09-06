using FluentValidation;
using Guide.Entities.Concrete.Exercises;

namespace Guide.Business.ValidationRules.FluentValidation
{
    public class ExerciseValidator : AbstractValidator<Exercise>
    {
        public ExerciseValidator()
        {
            RuleFor(e => e.Id).NotNull();
            RuleFor(e => e.Title).NotNull();
            RuleFor(e => e.Title).MinimumLength(1);
            RuleFor(e => e.Description).NotNull();
            RuleFor(e => e.Description).MinimumLength(1);
            RuleFor(e => e.CreateDate).NotNull();
            RuleFor(e => e.TimeCategoryId).NotNull();
        }
    }
}
