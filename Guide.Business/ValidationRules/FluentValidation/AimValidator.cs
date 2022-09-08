using FluentValidation;
using Guide.Entities.Concrete.Aims;

namespace Guide.Business.ValidationRules.FluentValidation
{
    public class AimValidator : AbstractValidator<Aim>
    {
        public AimValidator()
        {
            RuleFor(a => a.Title).NotNull();
            RuleFor(a => a.Title).MinimumLength(1);
            RuleFor(a => a.Description).NotNull();
            RuleFor(a => a.Description).MinimumLength(1);
            RuleFor(a => a.CreateDate).NotNull();
            RuleFor(a => a.IsConvertedToExercise).NotNull();
            RuleFor(a => a.TimeCategoryId).NotNull();
        }
    }
}
