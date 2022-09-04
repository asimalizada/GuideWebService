using Core.Business.Concrete;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using Guide.Business.Abstract;
using Guide.Business.Constants;
using Guide.Business.ValidationRules.FluentValidation;
using Guide.DataAccess.Abstract;
using Guide.Entities.Concrete;
using Guide.Entities.Constants;
using Guide.Entities.Models;

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

        public IDataResult<List<AimDetail>> GetAimDetails()
        {
            return new SuccessDataResult<List<AimDetail>>(_aimDal.GetAimDetails(), Messages.DataFound);
        }

        public IDataResult<List<AimDetail>> GetAimToDoDetails()
        {
            return new SuccessDataResult<List<AimDetail>>(_aimDal.GetAimToDoDetails(), Messages.DataFound);
        }

        public IDataResult<List<AimDetail>> GetDailyAims()
        {
            return new SuccessDataResult<List<AimDetail>>(_aimDal.GetAimDetails(a => a.TimeCategoryId == AimTimeCategory.Daily), Messages.DataFound);
        }

        public IDataResult<List<AimDetail>> GetDailyToDoAims()
        {
            return new SuccessDataResult<List<AimDetail>>(_aimDal.GetAimToDoDetails(a => a.TimeCategoryId == AimTimeCategory.Daily), Messages.DataFound);
        }

        public IDataResult<List<AimDetail>> GetMonthlyAims()
        {
            return new SuccessDataResult<List<AimDetail>>(_aimDal.GetAimDetails(a => a.TimeCategoryId == AimTimeCategory.Monthly), Messages.DataFound);
        }

        public IDataResult<List<AimDetail>> GetMonthlyToDoAims()
        {
            return new SuccessDataResult<List<AimDetail>>(_aimDal.GetAimToDoDetails(a => a.TimeCategoryId == AimTimeCategory.Monthly), Messages.DataFound);
        }

        public IDataResult<List<AimDetail>> GetWeeklyAims()
        {
            return new SuccessDataResult<List<AimDetail>>(_aimDal.GetAimDetails(a => a.TimeCategoryId == AimTimeCategory.Weekly), Messages.DataFound);
        }

        public IDataResult<List<AimDetail>> GetWeeklyToDoAims()
        {
            return new SuccessDataResult<List<AimDetail>>(_aimDal.GetAimToDoDetails(a => a.TimeCategoryId == AimTimeCategory.Weekly), Messages.DataFound);
        }
    }
}
