using Core.Business.Abstract;
using Core.Utilities.Results.Abstract;
using Guide.Entities.Concrete;

namespace Guide.Business.Abstract
{
    public interface IAimOperationService : IServiceRepository<AimOperation>
    {
        IDataResult<List<AimOperation>> GetByAim(int aimId);
        IDataResult<List<AimOperation>> GetByDate(DateTime date);
        IDataResult<List<AimOperation>> GetByDate(DateTime from, DateTime to);
    }
}
