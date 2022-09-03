using Core.DataAccess.Concrete.EntityFramework;
using Guide.DataAccess.Abstract;
using Guide.DataAccess.Concrete.EntityFramework.Contexts;
using Guide.Entities.Concrete;
using Guide.Entities.Constants;
using Guide.Entities.Models;
using System.Linq;
using System.Linq.Expressions;

namespace Guide.DataAccess.Concrete.EntityFramework
{
    public class EfExerciseDal : EfEntityRepositoryBase<Exercise, GuideContext>, IExerciseDal
    {
        public List<ExerciseDetail> GetExerciseDetails(Expression<Func<Exercise, bool>> filter = null)
        {
            using (var context = new GuideContext())
            {
                var result = from t in filter == null ? context.Exercises : context.Exercises.Where(filter)
                             join tc in context.ExerciseCategories on t.CategoryId equals tc.Id
                             select new ExerciseDetail
                             {
                                 Id = t.Id,
                                 Title = t.Title,
                                 Description = t.Description,
                                 CategoryName = tc.Name,
                                 CreateDate = t.CreateDate,
                                 DeadLine = t.DeadLine,
                                 TimeCategoryId = t.TimeCategoryId
                             };

                return result.ToList();
            }
        }

        public List<ExerciseDetail> GetExerciseToDoDetails(Expression<Func<Exercise, bool>> filter = null)
        {
            using (var context = new GuideContext())
            {
                var result = from t in filter == null ? context.Exercises : context.Exercises.Where(filter)
                             join op in context.AimOperations on t.Id equals op.AimId into gj
                             from o in gj.DefaultIfEmpty()
                             join tc in context.ExerciseCategories on t.CategoryId equals tc.Id
                             where o.CompleteDate != DateTime.Today //& o.OperationTypeId == OperationType.Task
                             select new ExerciseDetail
                             {
                                 Id = t.Id,
                                 Title = t.Title,
                                 Description = t.Description,
                                 CategoryName = tc.Name,
                                 CreateDate = t.CreateDate,
                                 DeadLine = t.DeadLine,
                                 TimeCategoryId = t.TimeCategoryId
                             };

                return result.ToList();
            }
        }

        public List<Exercise> GetDailyExercises(DateTime date)
        {
            using (var context = new GuideContext())
            {
                var result = from a in context.Exercises
                             join o in context.ExerciseOperations on a.Id equals o.TaskId
                             where a.CreateDate >= date &
                                   a.TimeCategoryId == ExerciseTimeCategory.Daily
                             select new Exercise
                             {
                                 Id = a.Id,
                                 CategoryId = a.CategoryId,
                                 CreateDate = a.CreateDate,
                                 Description = a.Description,
                                 TimeCategoryId = a.TimeCategoryId,
                                 Title = a.Title
                             };

                return result.ToList();
            }
        }

        public List<Exercise> GetExercisesForDate(DateTime begin, DateTime end)
        {
            using (var context = new GuideContext())
            {
                var result = from a in context.Exercises
                             join o in context.ExerciseOperations on a.Id equals o.TaskId
                             where (a.TimeCategoryId == ExerciseTimeCategory.Daily | a.TimeCategoryId == ExerciseTimeCategory.Weekly) &
                                   a.CreateDate >= begin &
                                   a.CreateDate <= end
                             select new Exercise
                             {
                                 Id = a.Id,
                                 CategoryId = a.CategoryId,
                                 CreateDate = a.CreateDate,
                                 Description = a.Description,
                                 TimeCategoryId = a.TimeCategoryId,
                                 Title = a.Title
                             };

                return result.ToList();
            }
        }

        public List<Exercise> GetDailyCompletedExercises(DateTime date)
        {
            using (var context = new GuideContext())
            {
                var result = from a in context.Exercises
                             join o in context.ExerciseOperations on a.Id equals o.TaskId
                             where a.CreateDate >= date &
                                   a.TimeCategoryId == ExerciseTimeCategory.Daily &
                                   o.CompleteDate == date
                             select new Exercise
                             {
                                 Id = a.Id,
                                 CategoryId = a.CategoryId,
                                 CreateDate = a.CreateDate,
                                 Description = a.Description,
                                 TimeCategoryId = a.TimeCategoryId,
                                 Title = a.Title
                             };

                return result.ToList();
            }
        }

        public double GetDailyReport(DateTime date)
        {
            using (var context = new GuideContext())
            {
                var allAims = this.GetDailyExercises(date);

                double all = allAims.Count();

                var completedAims = this.GetDailyCompletedExercises(date);

                double completeds = completedAims.Count();

                return (completeds / all) * 100;
            }
        }

        public WeeklyReport GetWeeklyReport(DateTime begin, DateTime end)
        {
            using (var context = new GuideContext())
            {
                var result = new WeeklyReport();

                result.Monday = this.GetDailyReport(begin);
                result.Tuesday = this.GetDailyReport(begin.AddDays(1));
                result.Wednesday = this.GetDailyReport(begin.AddDays(2));
                result.Thursday = this.GetDailyReport(begin.AddDays(3));
                result.Friday = this.GetDailyReport(begin.AddDays(4));
                result.Saturday = this.GetDailyReport(begin.AddDays(5));
                result.Sunday = this.GetDailyReport(begin.AddDays(6));


                return result;
            }
        }

        public List<Exercise> GetCompletedExercisesForDate(DateTime begin, DateTime end)
        {
            using (var context = new GuideContext())
            {
                var result = from a in context.Exercises
                             join o in context.ExerciseOperations on a.Id equals o.TaskId
                             where (a.TimeCategoryId == ExerciseTimeCategory.Daily | a.TimeCategoryId == ExerciseTimeCategory.Weekly) &
                                   a.CreateDate >= begin &
                                   a.CreateDate <= end
                             select new Exercise
                             {
                                 Id = a.Id,
                                 CategoryId = a.CategoryId,
                                 CreateDate = a.CreateDate,
                                 Description = a.Description,
                                 TimeCategoryId = a.TimeCategoryId,
                                 Title = a.Title
                             };

                return result.ToList();
            }
        }
    }
}
