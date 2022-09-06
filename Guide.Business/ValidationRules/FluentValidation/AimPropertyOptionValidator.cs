using FluentValidation;
using Guide.Entities.Concrete.Aims;

namespace Guide.Business.ValidationRules.FluentValidation
{
    public class AimPropertyOptionValidator : AbstractValidator<AimPropertyOption>
    {
        public AimPropertyOptionValidator()
        {
            RuleFor(a => a.Id).NotNull();
            RuleFor(a => a.Name).NotNull();
            RuleFor(a => a.Name).MinimumLength(1);
            RuleFor(a => a.AimPropertyId).NotNull();
            RuleFor(a => a.AimPropertyId).GreaterThan(0);
        }
    }
}
