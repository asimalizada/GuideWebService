using Guide.Business.Abstract;
using Guide.DataAccess.Abstract;

namespace Guide.Business.Concrete
{
    public class ReportManager : IReportService
    {
        private readonly IAimRepository _aimRepository;
        private readonly IExerciseRepository _exerciseRepository;

        public ReportManager(IExerciseRepository exerciseRepository, IAimRepository aimRepository)
        {
            _exerciseRepository = exerciseRepository;
            _aimRepository = aimRepository;
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
