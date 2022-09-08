using Core.Aspects.Autofac.Caching;
using Core.Business.Concrete;
using Core.Features.Results.Abstract;
using Core.Utilities.Results.Concrete;
using Guide.Business.Abstract;
using Guide.Business.Constants;
using Guide.Business.ValidationRules.FluentValidation;
using Guide.DataAccess.Abstract;
using Guide.Entities.Concrete.Aims;

namespace Guide.Business.Concrete
{
    public class AimOperationManager : ManagerRepositoryBase<AimOperation, IAimOperationDal>, IAimOperationService
    {
        private readonly IAimOperationDal _aimOperationDal;
        public AimOperationManager(IAimOperationDal dal) : base(dal)
        {
            _aimOperationDal = dal;
            base.SetValidator(new AimOperationValidator());
        }

        [CacheAspect]
        public IDataResult<List<AimOperation>> GetByAim(int aimId)
        {
            return new SuccessDataResult<List<AimOperation>>(_aimOperationDal.GetAll(a => a.AimId == aimId), Messages.DataFound);
        }

        [CacheAspect]
        public IDataResult<List<AimOperation>> GetByDate(DateTime date)
        {
            return new SuccessDataResult<List<AimOperation>>(_aimOperationDal.GetAll(a => a.CompleteDate == date), Messages.DataFound);
        }

        [CacheAspect]
        public IDataResult<List<AimOperation>> GetByDate(DateTime from, DateTime to)
        {
            return new SuccessDataResult<List<AimOperation>>(_aimOperationDal.GetAll(a => a.CompleteDate >= from & a.CompleteDate <= to), Messages.DataFound);
        }
    }
}
