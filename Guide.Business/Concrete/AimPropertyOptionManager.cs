using Core.Business.Concrete;
using Guide.Business.Abstract;
using Guide.Business.ValidationRules.FluentValidation;
using Guide.DataAccess.Abstract;
using Guide.Entities.Concrete.Aims;

namespace Guide.Business.Concrete
{
    public class AimPropertyOptionManager : ManagerRepositoryBase<AimPropertyOption, IAimPropertyOptionRepository>, IAimPropertyOptionService
    {
        public AimPropertyOptionManager(IAimPropertyOptionRepository repository) : base(repository)
        {
            base.SetValidator(new AimPropertyOptionValidator());
        }
    }
}
