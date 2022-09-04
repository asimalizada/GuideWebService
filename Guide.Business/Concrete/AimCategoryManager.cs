using Core.Business.Concrete;
using Guide.Business.Abstract;
using Guide.Business.ValidationRules.FluentValidation;
using Guide.DataAccess.Abstract;
using Guide.Entities.Concrete;

namespace Guide.Business.Concrete
{
    public class AimCategoryManager : ManagerRepositoryBase<AimCategory, IAimCategoryDal>, IAimCategoryService
    {
        public AimCategoryManager(IAimCategoryDal dal) : base(dal)
        {
            base.SetValidator(new AimCategoryValidator());
        }
    }
}
