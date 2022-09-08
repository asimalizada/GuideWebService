using Core.DataAccess.Repositories.EntityFramework;
using Guide.DataAccess.Abstract;
using Guide.DataAccess.Concrete.EntityFramework.Contexts;
using Guide.Entities.Concrete.Aims;

namespace Guide.DataAccess.Concrete.EntityFramework
{
    public class EfAimPropertyOptionRepository : EfRepositoryBase<AimPropertyOption, GuideContext>, IAimPropertyOptionRepository
    {
        public EfAimPropertyOptionRepository(GuideContext context) : base(context)
        {

        }
    }
}
