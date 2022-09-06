using Core.DataAccess.Concrete.EntityFramework;
using Guide.DataAccess.Abstract;
using Guide.DataAccess.Concrete.EntityFramework.Contexts;
using Guide.Entities.Concrete.Exercises;
using Guide.Entities.Constants;
using Guide.Entities.Models;
using System.Linq.Expressions;

namespace Guide.DataAccess.Concrete.EntityFramework
{
    public class EfExerciseOperationDal : EfEntityRepositoryBase<ExerciseOperation, GuideContext>, IExerciseOperationDal
    {
    }
}
