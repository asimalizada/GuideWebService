using FluentValidation;
using Guide.Entities.Concrete;

namespace Guide.Business.ValidationRules.FluentValidation
{
    public class ExerciseValidator : AbstractValidator<Exercise>
    {
        public ExerciseValidator()
        {

        }
    }
}
