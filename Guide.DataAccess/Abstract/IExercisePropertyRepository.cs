using Core.DataAccess.Repositories;
using Guide.Entities.Concrete.Exercises;

namespace Guide.DataAccess.Abstract
{
    public interface IExercisePropertyRepository : IRepository<ExerciseProperty>, IAsyncRepository<ExerciseProperty>
    {
    }
}
