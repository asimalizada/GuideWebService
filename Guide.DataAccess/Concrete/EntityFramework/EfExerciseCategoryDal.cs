﻿using Core.DataAccess.Concrete.EntityFramework;
using Guide.DataAccess.Abstract;
using Guide.DataAccess.Concrete.EntityFramework.Contexts;
using Guide.Entities.Concrete;
using Guide.Entities.Constants;
using Guide.Entities.Models;
using System.Linq.Expressions;

namespace Guide.DataAccess.Concrete.EntityFramework
{
    public class EfExerciseCategoryDal : EfEntityRepositoryBase<ExerciseCategory, GuideContext>, IExerciseCategoryDal
    {
    }
}