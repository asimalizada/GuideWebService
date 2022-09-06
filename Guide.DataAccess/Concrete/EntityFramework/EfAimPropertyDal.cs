﻿using Core.DataAccess.Concrete.EntityFramework;
using Guide.DataAccess.Abstract;
using Guide.DataAccess.Concrete.EntityFramework.Contexts;
using Guide.Entities.Concrete.Aims;

namespace Guide.DataAccess.Concrete.EntityFramework
{
    public class EfAimPropertyDal : EfEntityRepositoryBase<AimProperty, GuideContext>, IAimPropertyDal
    {
    }
}