using FluentValidation;
using Guide.Entities.Concrete;

namespace Guide.Business.ValidationRules.FluentValidation
{
    public class AimCategoryValidator : AbstractValidator<AimCategory>
    {
        public AimCategoryValidator()
        {
            RuleFor(a => a.Id).NotEmpty();
            RuleFor(a => a.Name).NotEmpty();
            RuleFor(a => a.Name).MinimumLength(1);
        }
    }
}
