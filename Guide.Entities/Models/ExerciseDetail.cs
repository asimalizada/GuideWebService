using Core.Entities.Abstract;
using Guide.Entities.Constants;
using System;

namespace Guide.Entities.Models
{
    public class ExerciseDetail : IModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string CategoryName { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? DeadLine { get; set; }
        public ExerciseTimeCategory TimeCategoryId { get; set; }
    }
}
