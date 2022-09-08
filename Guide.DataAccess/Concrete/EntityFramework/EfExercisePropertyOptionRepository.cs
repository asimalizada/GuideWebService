using Core.DataAccess.Repositories.EntityFramework;
using Guide.DataAccess.Abstract;
using Guide.DataAccess.Concrete.EntityFramework.Contexts;
using Guide.Entities.Concrete.Exercises;

namespace Guide.DataAccess.Concrete.EntityFramework
{
    public class EfExercisePropertyOptionRepository : EfRepositoryBase<ExercisePropertyOption, GuideContext>, IExercisePropertyOptionRepository
    {
        public EfExercisePropertyOptionRepository(GuideContext context) : base(context)
        {

        }
    }
}
