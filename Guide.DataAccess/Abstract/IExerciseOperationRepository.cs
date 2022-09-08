using Core.DataAccess.Repositories;
using Guide.Entities.Concrete.Exercises;

namespace Guide.DataAccess.Abstract
{
    public interface IExerciseOperationRepository : IExtendedRepository<ExerciseOperation>
    {
    }
}
