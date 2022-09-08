using Core.DataAccess.Repositories;
using Guide.Entities.Concrete.Aims;

namespace Guide.DataAccess.Abstract
{
    public interface IAimOperationRepository : IRepository<AimOperation>, IAsyncRepository<AimOperation>
    {
    }
}
