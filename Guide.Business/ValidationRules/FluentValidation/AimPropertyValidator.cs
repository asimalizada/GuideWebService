using FluentValidation;
using Guide.Entities.Concrete.Aims;

namespace Guide.Business.ValidationRules.FluentValidation
{
    public class AimPropertyValidator : AbstractValidator<AimProperty>
    {
        public AimPropertyValidator()
        {
            RuleFor(a => a.Id).NotNull();
            RuleFor(a => a.Name).NotNull();
            RuleFor(a => a.Name).MinimumLength(1);
            RuleFor(a => a.Type).NotNull();
        }
    }
}
