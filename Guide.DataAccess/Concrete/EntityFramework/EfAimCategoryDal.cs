using Core.DataAccess.Concrete.EntityFramework;
using Guide.DataAccess.Abstract;
using Guide.DataAccess.Concrete.EntityFramework.Contexts;
using Guide.Entities.Concrete;
using Guide.Entities.Constants;
using Guide.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guide.DataAccess.Concrete.EntityFramework
{
    public class EfAimCategoryDal : EfEntityRepositoryBase<AimCategory, GuideContext>, IAimCategoryDal
    {
    }
}
