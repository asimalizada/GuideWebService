using Core.Business.Abstract;
using Core.Utilities.Results.Abstract;
using Guide.Entities.Concrete.Aims;
using Guide.Entities.Models;
using Guide.Entities.Models.Aims;

namespace Guide.Business.Abstract
{
    public interface IAimService : IServiceRepository<Aim>
    {
        //IDataResult<List<AimModel>> GetAimDetails();
        //IDataResult<List<AimModel>> GetDailyAims();
        //IDataResult<List<AimModel>> GetWeeklyAims();
        //IDataResult<List<AimModel>> GetMonthlyAims();
        //IDataResult<List<AimModel>> GetAimToDoDetails();
        //IDataResult<List<AimModel>> GetDailyToDoAims();
        //IDataResult<List<AimModel>> GetWeeklyToDoAims();
        //IDataResult<List<AimModel>> GetMonthlyToDoAims();
    }
}
