using Core.Business.Concrete;
using Guide.Business.Abstract;
using Guide.Business.ValidationRules.FluentValidation;
using Guide.DataAccess.Abstract;
using Guide.Entities.Concrete.Aims;

namespace Guide.Business.Concrete
{
    public class AimPropertyManager : ManagerRepositoryBase<AimProperty, IAimPropertyDal>, IAimPropertyService
    {
        public AimPropertyManager(IAimPropertyDal dal) : base(dal)
        {
            base.SetValidator(new AimPropertyValidator());
        }
    }
}
