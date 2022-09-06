using Core.Aspects.Autofac.Caching;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using Guide.Business.Abstract;
using Guide.Business.Constants;
using Guide.DataAccess.Abstract;
using Guide.Entities.Models;

namespace Guide.Business.Concrete
{
    public class ReportManager : IReportService
    {
        private readonly IAimDal _aimDal;
        private readonly IExerciseDal _exerciseDal;

        public ReportManager(IExerciseDal exerciseDal, IAimDal aimDal)
        {
            _exerciseDal = exerciseDal;
            _aimDal = aimDal;
        }

        //[CacheAspect]
        //public IDataResult<double> DailyAimReport(DateTime date)
        //{
        //    return new SuccessDataResult<double>(_aimDal.GetDailyReport(date), Messages.DataFound);
        //}

        //[CacheAspect]
        //public IDataResult<double> DailyExerciseReport(DateTime date)
        //{
        //    return new SuccessDataResult<double>(_exerciseDal.GetDailyReport(date), Messages.DataFound);
        //}

        //[CacheAspect]
        //public IDataResult<WeeklyReport> WeeklyAimReport(DateTime begin, DateTime end)
        //{
        //    return new SuccessDataResult<WeeklyReport>(_aimDal.GetWeeklyReport(begin, end), Messages.DataFound);
        //}

        //[CacheAspect]
        //public IDataResult<WeeklyReport> WeeklyExerciseReport(DateTime begin, DateTime end)
        //{
        //    return new SuccessDataResult<WeeklyReport>(_exerciseDal.GetWeeklyReport(begin, end), Messages.DataFound);
        //}
    }
}
