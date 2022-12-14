using Core.Business.Concrete;
using Guide.Business.Abstract;
using Guide.Business.ValidationRules.FluentValidation;
using Guide.DataAccess.Abstract;
using Guide.Entities.Concrete.Aims;

namespace Guide.Business.Concrete
{
    public class AimPropertyValueManager : ManagerRepositoryBase<AimPropertyValue, IAimPropertyValueRepository>, IAimPropertyValueService
    {
        public AimPropertyValueManager(IAimPropertyValueRepository repository) : base(repository)
        {
            base.SetValidator(new AimPropertyValueValidator());
        }
    }
}
