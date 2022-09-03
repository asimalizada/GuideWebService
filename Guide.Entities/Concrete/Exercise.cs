using Core.Entities.Abstract;
using System;
using Guide.Entities.Constants;

namespace Guide.Entities.Concrete
{
    public class Exercise : IEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? DeadLine { get; set; }
        public ExerciseTimeCategory TimeCategoryId { get; set; }
    }
}
