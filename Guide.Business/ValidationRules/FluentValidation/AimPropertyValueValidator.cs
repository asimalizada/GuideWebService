using FluentValidation;
using Guide.Entities.Concrete.Aims;

namespace Guide.Business.ValidationRules.FluentValidation
{
    public class AimPropertyValueValidator : AbstractValidator<AimPropertyValue>
    {
        public AimPropertyValueValidator()
        {
            RuleFor(a => a.Id).NotNull();
            RuleFor(a => a.Value).NotNull();
            RuleFor(a => a.Value).MinimumLength(1);
            RuleFor(a => a.AimId).NotNull();
            RuleFor(a => a.AimId).GreaterThan(0);
            RuleFor(a => a.PropertyId).NotNull();
            RuleFor(a => a.PropertyId).GreaterThan(0);
        }
    }
}
