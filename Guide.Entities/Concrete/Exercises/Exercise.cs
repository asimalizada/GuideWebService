using Core.Entities.Abstract;
using System;
using Guide.Entities.Constants;

namespace Guide.Entities.Concrete.Exercises
{
    public class Exercise : IEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? DeadLine { get; set; }
        public ExerciseTimeCategory TimeCategoryId { get; set; }
    }
}
