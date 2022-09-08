using Core.DataAccess.Repositories;
using Guide.Entities.Concrete.Exercises;

namespace Guide.DataAccess.Abstract
{
    public interface IExercisePropertyOptionRepository : IRepository<ExercisePropertyOption>, IAsyncRepository<ExercisePropertyOption>
    {
    }
}
