using Core.DataAccess.Repositories.EntityFramework;
using Guide.DataAccess.Abstract;
using Guide.DataAccess.Concrete.EntityFramework.Contexts;
using Guide.Entities.Concrete.Aims;
using Guide.Entities.Models.Aims;
using System.Linq.Expressions;

namespace Guide.DataAccess.Concrete.EntityFramework
{
    public class EfAimRepository : EfRepositoryBase<Aim, GuideContext>, IAimRepository
    {
        public EfAimRepository(GuideContext context) : base(context)
        {

        }

        //public List<AimModel> GetAimDetails(Expression<Func<Aim, bool>> filter = null)
        //{
        //    using (var context = new GuideContext())
        //    {
        //        var result = from a in filter == null ? context.Aims : context.Aims.Where(filter)
        //                     join t in context.ExerciseCategories on a.CategoryId equals t.Id
        //                     select new AimModel
        //                     {
        //                         Id = a.Id,
        //                         Title = a.Title,
        //                         Description = a.Description,
        //                         CreateDate = a.CreateDate,
        //                         TimeCategoryId = a.TimeCategoryId
        //                     };

        //        return result.ToList();
        //    }
        //}

        //public List<AimModel> GetAimToDoDetails(Expression<Func<Aim, bool>> filter = null)
        //{
        //    using (var context = new GuideContext())
        //    {
        //        var result = from a in filter == null ? context.Aims : context.Aims.Where(filter)
        //                     join t in context.ExerciseCategories on a.CategoryId equals t.Id
        //                     join o in context.AimOperations on a.Id equals o.AimId
        //                     where o.CompleteDate != DateTime.Today
        //                     select new AimDetail
        //                     {
        //                         Id = a.Id,
        //                         Title = a.Title,
        //                         Description = a.Description,
        //                         CategoryName = t.Name,
        //                         CreateDate = a.CreateDate,
        //                         TimeCategoryId = a.TimeCategoryId
        //                     };

        //        return result.ToList();
        //    }
        //}

        //public List<Aim> GetDailyAims(DateTime date)
        //{
        //    using (var context = new GuideContext())
        //    {
        //        var result = from a in context.Aims
        //                     join o in context.AimOperations on a.Id equals o.AimId
        //                     where a.CreateDate >= date &
        //                           a.TimeCategoryId == AimTimeCategory.Daily
        //                     select a;
        //        //select new Aim
        //        //{
        //        //    Id = a.Id,
        //        //    CategoryId = a.CategoryId,
        //        //    CreateDate = a.CreateDate,
        //        //    Description = a.Description,
        //        //    IsConvertedToTask = a.IsConvertedToTask,
        //        //    TimeCategoryId = a.TimeCategoryId,
        //        //    Title = a.Title
        //        //};

        //        return result.ToList();
        //    }
        //}

        //public List<Aim> GetAimsForDate(DateTime begin, DateTime end)
        //{
        //    using (var context = new GuideContext())
        //    {
        //        var result = from a in context.Aims
        //                     join o in context.AimOperations on a.Id equals o.AimId
        //                     where (a.TimeCategoryId == AimTimeCategory.Daily | a.TimeCategoryId == AimTimeCategory.Weekly) &
        //                           a.CreateDate >= begin &
        //                           a.CreateDate <= end
        //                     select new Aim
        //                     {
        //                         Id = a.Id,
        //                         CategoryId = a.CategoryId,
        //                         CreateDate = a.CreateDate,
        //                         Description = a.Description,
        //                         IsConvertedToTask = a.IsConvertedToTask,
        //                         TimeCategoryId = a.TimeCategoryId,
        //                         Title = a.Title
        //                     };

        //        return result.ToList();
        //    }
        //}

        //public List<Aim> GetDailyCompletedAims(DateTime date)
        //{
        //    using (var context = new GuideContext())
        //    {
        //        var result = from a in context.Aims
        //                     join o in context.AimOperations on a.Id equals o.AimId
        //                     where a.CreateDate >= date &
        //                           a.TimeCategoryId == AimTimeCategory.Daily &
        //                           o.CompleteDate == date
        //                     select a;
        //        //select new Aim
        //        //{
        //        //    Id = a.Id,
        //        //    CategoryId = a.CategoryId,
        //        //    CreateDate = a.CreateDate,
        //        //    Description = a.Description,
        //        //    IsConvertedToTask = a.IsConvertedToTask,
        //        //    TimeCategoryId = a.TimeCategoryId,
        //        //    Title = a.Title
        //        //};

        //        return result.ToList();
        //    }
        //}

        //public double GetDailyReport(DateTime date)
        //{
        //    using (var context = new GuideContext())
        //    {
        //        var allAims = this.GetDailyAims(date);

        //        double all = allAims.Count();

        //        var completedAims = this.GetDailyCompletedAims(date);

        //        double completeds = completedAims.Count();

        //        if (all != 0)
        //            return (completeds / all) * 100;
        //        else return 0;
        //    }
        //}

        //public WeeklyReport GetWeeklyReport(DateTime begin, DateTime end)
        //{
        //    using (var context = new GuideContext())
        //    {
        //        var result = new WeeklyReport();

        //        result.Monday = this.GetDailyReport(begin);
        //        result.Tuesday = this.GetDailyReport(begin.AddDays(1));
        //        result.Wednesday = this.GetDailyReport(begin.AddDays(2));
        //        result.Thursday = this.GetDailyReport(begin.AddDays(3));
        //        result.Friday = this.GetDailyReport(begin.AddDays(4));
        //        result.Saturday = this.GetDailyReport(begin.AddDays(5));
        //        result.Sunday = this.GetDailyReport(begin.AddDays(6));


        //        return result;
        //    }
        //}

        //public List<Aim> GetCompletedAimsForDate(DateTime begin, DateTime end)
        //{
        //    using (var context = new GuideContext())
        //    {
        //        var result = from a in context.Aims
        //                     join o in context.AimOperations on a.Id equals o.AimId
        //                     where (a.TimeCategoryId == AimTimeCategory.Daily | a.TimeCategoryId == AimTimeCategory.Weekly) &
        //                           a.CreateDate >= begin &
        //                           a.CreateDate <= end
        //                     select new Aim
        //                     {
        //                         Id = a.Id,
        //                         CategoryId = a.CategoryId,
        //                         CreateDate = a.CreateDate,
        //                         Description = a.Description,
        //                         IsConvertedToTask = a.IsConvertedToTask,
        //                         TimeCategoryId = a.TimeCategoryId,
        //                         Title = a.Title
        //                     };

        //        return result.ToList();
        //    }
        //}

        public List<AimModel> GetAims(Expression<Func<Aim, bool>> filter = null)
        {
            var result = new List<AimModel>();
            var aims = filter == null ? Context.Aims.ToList() : Context.Aims.Where(filter).ToList();

            foreach (var aim in aims)
            {
                var temp = new AimModel
                {
                    Id = aim.Id,
                    Title = aim.Title,
                    Description = aim.Description,
                    CreateDate = aim.CreateDate,
                    IsConvertedToTask = aim.IsConvertedToExercise,
                    TimeCategoryId = aim.TimeCategoryId,
                    Properties = Context.AimPropertyValues.Where(a => a.AimId == aim.Id).ToList()
                };

                result.Add(temp);
            }

            return result;
        }

        public List<AimModel> GetAims(List<Aim> aims)
        {
            var result = new List<AimModel>();

            foreach (var aim in aims)
            {
                var temp = new AimModel
                {
                    Id = aim.Id,
                    Title = aim.Title,
                    Description = aim.Description,
                    CreateDate = aim.CreateDate,
                    IsConvertedToTask = aim.IsConvertedToExercise,
                    TimeCategoryId = aim.TimeCategoryId,
                    Properties = Context.AimPropertyValues.Where(a => a.AimId == aim.Id).ToList()
                };

                result.Add(temp);
            }

            return result;
        }
    }
}
