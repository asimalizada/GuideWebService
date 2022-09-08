using Core.Business.Concrete;
using Guide.Business.Abstract;
using Guide.Business.ValidationRules.FluentValidation;
using Guide.DataAccess.Abstract;
using Guide.Entities.Concrete.Aims;

namespace Guide.Business.Concrete
{
    public class AimPropertyManager : ManagerRepositoryBase<AimProperty, IAimPropertyRepository>, IAimPropertyService
    {
        public AimPropertyManager(IAimPropertyRepository repository) : base(repository)
        {
            base.SetValidator(new AimPropertyValidator());
        }
    }
}
