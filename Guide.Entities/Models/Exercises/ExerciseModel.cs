using Core.Entities.Abstract;
using Guide.Entities.Concrete.Exercises;
using Guide.Entities.Constants;
using System;

namespace Guide.Entities.Models.Exercises
{
    public class ExerciseModel : IModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? DeadLine { get; set; }
        public ExerciseTimeCategory TimeCategoryId { get; set; }
        public List<ExercisePropertyValue> Properties { get; set; }
    }
}
