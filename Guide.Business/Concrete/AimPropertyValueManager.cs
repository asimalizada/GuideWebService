using Core.Business.Concrete;
using Guide.Business.Abstract;
using Guide.Business.ValidationRules.FluentValidation;
using Guide.DataAccess.Abstract;
using Guide.Entities.Concrete.Aims;

namespace Guide.Business.Concrete
{
    public class AimPropertyValueManager : ManagerRepositoryBase<AimPropertyValue, IAimPropertyValueDal>, IAimPropertyValueService
    {
        public AimPropertyValueManager(IAimPropertyValueDal dal) : base(dal)
        {
            base.SetValidator(new AimPropertyValueValidator());
        }
    }
}
