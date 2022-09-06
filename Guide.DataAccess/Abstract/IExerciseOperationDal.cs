using Core.DataAccess.Abstract;
using Guide.Entities.Concrete.Exercises;
using System;
namespace Guide.DataAccess.Abstract
{
    public interface IExerciseOperationDal : IEntityRepository<ExerciseOperation>
    {
    }
}
