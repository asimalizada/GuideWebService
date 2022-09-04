using Core.Business.Abstract;
using Core.Utilities.Results.Abstract;
using Guide.Entities.Concrete;
using Guide.Entities.Models;

namespace Guide.Business.Abstract
{
    public interface IAimService : IServiceRepository<Aim>
    {
        IDataResult<List<AimDetail>> GetAimDetails();
        IDataResult<List<AimDetail>> GetDailyAims();
        IDataResult<List<AimDetail>> GetWeeklyAims();
        IDataResult<List<AimDetail>> GetMonthlyAims();
        IDataResult<List<AimDetail>> GetAimToDoDetails();
        IDataResult<List<AimDetail>> GetDailyToDoAims();
        IDataResult<List<AimDetail>> GetWeeklyToDoAims();
        IDataResult<List<AimDetail>> GetMonthlyToDoAims();
    }
}
