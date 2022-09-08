using Core.DataAccess.Repositories.EntityFramework;
using Guide.DataAccess.Abstract;
using Guide.DataAccess.Concrete.EntityFramework.Contexts;
using Guide.Entities.Concrete.Exercises;

namespace Guide.DataAccess.Concrete.EntityFramework
{
    public class EfExercisePropertyValueRepository : EfRepositoryBase<ExercisePropertyValue, GuideContext>, IExercisePropertyValueRepository
    {
        public EfExercisePropertyValueRepository(GuideContext context) : base(context)
        {

        }
    }
}
