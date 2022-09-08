using Core.Business.Concrete;
using Guide.Business.Abstract;
using Guide.Business.ValidationRules.FluentValidation;
using Guide.DataAccess.Abstract;
using Guide.Entities.Concrete.Aims;

namespace Guide.Business.Concrete
{
    public class AimManager : ManagerRepositoryBase<Aim, IAimRepository>, IAimService
    {
        private readonly IAimRepository _aimRepository;

        public AimManager(IAimRepository repository) : base(repository)
        {
            _aimRepository = repository;
            base.SetValidator(new AimValidator());
        }

        //[CacheAspect]
        //public IDataResult<List<AimModel>> GetAimDetails()
        //{
        //    return new SuccessDataResult<List<AimModel>>(_aimDal.GetAimDetails(), Messages.DataFound);
        //}

        //[CacheAspect]
        //public IDataResult<List<AimModel>> GetAimToDoDetails()
        //{
        //    return new SuccessDataResult<List<AimModel>>(_aimDal.GetAimToDoDetails(), Messages.DataFound);
        //}

        //[CacheAspect]
        //public IDataResult<List<AimModel>> GetDailyAims()
        //{
        //    return new SuccessDataResult<List<AimModel>>(_aimDal.GetAimDetails(a => a.TimeCategoryId == AimTimeCategory.Daily), Messages.DataFound);
        //}

        //[CacheAspect]
        //public IDataResult<List<AimModel>> GetDailyToDoAims()
        //{
        //    return new SuccessDataResult<List<AimModel>>(_aimDal.GetAimToDoDetails(a => a.TimeCategoryId == AimTimeCategory.Daily), Messages.DataFound);
        //}

        //[CacheAspect]
        //public IDataResult<List<AimModel>> GetMonthlyAims()
        //{
        //    return new SuccessDataResult<List<AimModel>>(_aimDal.GetAimDetails(a => a.TimeCategoryId == AimTimeCategory.Monthly), Messages.DataFound);
        //}

        //[CacheAspect]
        //public IDataResult<List<AimModel>> GetMonthlyToDoAims()
        //{
        //    return new SuccessDataResult<List<AimModel>>(_aimDal.GetAimToDoDetails(a => a.TimeCategoryId == AimTimeCategory.Monthly), Messages.DataFound);
        //}

        //[CacheAspect]
        //public IDataResult<List<AimModel>> GetWeeklyAims()
        //{
        //    return new SuccessDataResult<List<AimModel>>(_aimDal.GetAimDetails(a => a.TimeCategoryId == AimTimeCategory.Weekly), Messages.DataFound);
        //}

        //[CacheAspect]
        //public IDataResult<List<AimModel>> GetWeeklyToDoAims()
        //{
        //    return new SuccessDataResult<List<AimModel>>(_aimDal.GetAimToDoDetails(a => a.TimeCategoryId == AimTimeCategory.Weekly), Messages.DataFound);
        //}
    }
}
