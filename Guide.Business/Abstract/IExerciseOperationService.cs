using Core.Business.Abstract;
using Core.Utilities.Results.Abstract;
using Guide.Entities.Concrete.Exercises;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guide.Business.Abstract
{
    public interface IExerciseOperationService : IServiceRepository<ExerciseOperation>
    {
        IDataResult<List<ExerciseOperation>> GetByDate(DateTime date);
        IDataResult<List<ExerciseOperation>> GetByDate(DateTime from, DateTime to);
    }
}
