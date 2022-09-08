using Core.Entities.Concrete;
using Guide.Entities.Constants;

namespace Guide.Entities.Concrete.Exercises
{
    public class Exercise : Entity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? DeadLine { get; set; }
        public ExerciseTimeCategory TimeCategoryId { get; set; }

        public Exercise()
        {

        }

        public Exercise(int id, string title, string description, DateTime createDate, DateTime? deadLine, ExerciseTimeCategory timeCategoryId) : this()
        {
            Id = id;
            Title = title;
            Description = description;
            CreateDate = createDate;
            DeadLine = deadLine;
            TimeCategoryId = timeCategoryId;
        }
    }
}
