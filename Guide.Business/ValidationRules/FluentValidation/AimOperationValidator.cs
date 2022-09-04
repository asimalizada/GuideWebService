using FluentValidation;
using Guide.Entities.Concrete;

namespace Guide.Business.ValidationRules.FluentValidation
{
    public class AimOperationValidator : AbstractValidator<AimOperation>
    {
        public AimOperationValidator()
        {
            RuleFor(a=>a.Id).NotEmpty();
            RuleFor(a => a.CompleteDate).NotEmpty();
            RuleFor(a=>a.AimId).NotEmpty();
            RuleFor(a => a.AimId).GreaterThan(0);
        }
    }
}
