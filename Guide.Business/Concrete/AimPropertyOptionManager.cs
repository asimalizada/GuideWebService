using Core.Business.Concrete;
using Guide.Business.Abstract;
using Guide.Business.ValidationRules.FluentValidation;
using Guide.DataAccess.Abstract;
using Guide.Entities.Concrete.Aims;

namespace Guide.Business.Concrete
{
    public class AimPropertyOptionManager : ManagerRepositoryBase<AimPropertyOption, IAimPropertyOptionDal>, IAimPropertyOptionService
    {
        public AimPropertyOptionManager(IAimPropertyOptionDal dal) : base(dal)
        {
            base.SetValidator(new AimPropertyOptionValidator());
        }
    }
}
