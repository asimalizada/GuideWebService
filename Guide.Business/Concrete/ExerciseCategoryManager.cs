using Core.Business.Concrete;
using Guide.Business.Abstract;
using Guide.Business.ValidationRules.FluentValidation;
using Guide.DataAccess.Abstract;
using Guide.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guide.Business.Concrete
{
    public class ExerciseCategoryManager : ManagerRepositoryBase<ExerciseCategory, IExerciseCategoryDal>, IExerciseCategoryService
    {
        protected ExerciseCategoryManager(IExerciseCategoryDal dal) : base(dal)
        {
            base.SetValidator(new ExerciseCategoryValidator());
        }
    }
}
