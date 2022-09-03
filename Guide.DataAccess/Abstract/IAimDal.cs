using Core.DataAccess.Abstract;
using Guide.Entities.Concrete;
using Guide.Entities.Models;
using System.Linq.Expressions;
namespace Guide.DataAccess.Abstract
{
    public interface IAimDal : IEntityRepository<Aim>
    {
        List<AimDetail> GetAimDetails(Expression<Func<Aim, bool>> filter = null);
        List<AimDetail> GetAimToDoDetails(Expression<Func<Aim, bool>> filter = null);
        double GetDailyReport(DateTime date);
        WeeklyReport GetWeeklyReport(DateTime begin, DateTime end);
        List<Aim> GetDailyAims(DateTime date);
        List<Aim> GetDailyCompletedAims(DateTime begin);
        List<Aim> GetAimsForDate(DateTime begin, DateTime end);
        List<Aim> GetCompletedAimsForDate(DateTime begin, DateTime end);
    }
}
