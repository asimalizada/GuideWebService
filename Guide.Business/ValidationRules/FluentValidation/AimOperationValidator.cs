using FluentValidation;
using Guide.Entities.Concrete.Aims;

namespace Guide.Business.ValidationRules.FluentValidation
{
    public class AimOperationValidator : AbstractValidator<AimOperation>
    {
        public AimOperationValidator()
        {
            RuleFor(a=>a.Id).NotNull();
            RuleFor(a => a.CompleteDate).NotNull();
            RuleFor(a=>a.AimId).NotNull();
            RuleFor(a => a.AimId).GreaterThan(0);
        }
    }
}
