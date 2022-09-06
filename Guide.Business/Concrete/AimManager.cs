using Core.Aspects.Autofac.Caching;
using Core.Business.Concrete;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using Guide.Business.Abstract;
using Guide.Business.Constants;
using Guide.Business.ValidationRules.FluentValidation;
using Guide.DataAccess.Abstract;
using Guide.Entities.Concrete.Aims;
using Guide.Entities.Constants;
using Guide.Entities.Models;
using Guide.Entities.Models.Aims;

namespace Guide.Business.Concrete
{
    public class AimManager : ManagerRepositoryBase<Aim, IAimDal>, IAimService
    {
        private readonly IAimDal _aimDal;

        public AimManager(IAimDal dal) : base(dal)
        {
            _aimDal = dal;
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
