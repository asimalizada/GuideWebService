using Core.DataAccess.Repositories;
using Guide.Entities.Concrete.Aims;
using Guide.Entities.Models.Aims;
using System.Linq.Expressions;

namespace Guide.DataAccess.Abstract
{
    public interface IAimRepository : IExtendedRepository<Aim>
    {
        List<AimModel> GetAims(Expression<Func<Aim, bool>> filter = null);
        List<AimModel> GetAims(List<Aim> aims);

        //List<AimModel> GetAimDetails(Expression<Func<Aim, bool>> filter = null);
        //List<AimModel> GetAimToDoDetails(Expression<Func<Aim, bool>> filter = null);
        //double GetDailyReport(DateTime date);
        //WeeklyReport GetWeeklyReport(DateTime begin, DateTime end);
        //List<Aim> GetDailyAims(DateTime date);
        //List<Aim> GetDailyCompletedAims(DateTime begin);
        //List<Aim> GetAimsForDate(DateTime begin, DateTime end);
        //List<Aim> GetCompletedAimsForDate(DateTime begin, DateTime end);
    }
}
