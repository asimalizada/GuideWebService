using Core.DataAccess.Repositories.EntityFramework;
using Guide.DataAccess.Abstract;
using Guide.DataAccess.Concrete.EntityFramework.Contexts;
using Guide.Entities.Concrete.Exercises;

namespace Guide.DataAccess.Concrete.EntityFramework
{
    public class EfExerciseOperationRepository : EfRepositoryBase<ExerciseOperation, GuideContext>, IExerciseOperationRepository
    {
        public EfExerciseOperationRepository(GuideContext context) : base(context)
        {

        }
    }
}
