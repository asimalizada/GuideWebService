﻿using Core.DataAccess.Concrete.EntityFramework;
using Guide.DataAccess.Abstract;
using Guide.DataAccess.Concrete.EntityFramework.Contexts;
using Guide.Entities.Concrete.Exercises;

namespace Guide.DataAccess.Concrete.EntityFramework
{
    public class EfExercisePropertyValueDal : EfEntityRepositoryBase<ExercisePropertyValue, GuideContext>, IExercisePropertyValueDal
    {
    }
}