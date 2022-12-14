using Core.DataAccess.Repositories.EntityFramework;
using Guide.DataAccess.Abstract;
using Guide.DataAccess.Concrete.EntityFramework.Contexts;
using Guide.Entities.Concrete.Aims;
using Guide.Entities.Constants;
using Guide.Entities.Models;
using System.Linq.Expressions;

namespace Guide.DataAccess.Concrete.EntityFramework
{
    public class EfAimOperationRepository : EfRepositoryBase<AimOperation, GuideContext>, IAimOperationRepository
    {
        public EfAimOperationRepository(GuideContext context) : base(context)
        {

        }
    }
}
