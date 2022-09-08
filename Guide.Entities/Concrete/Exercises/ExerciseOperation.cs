using Core.Entities.Concrete;

namespace Guide.Entities.Concrete.Exercises
{
    public class ExerciseOperation : Entity
    {
        public DateTime CompleteDate { get; set; }
        public int ExerciseId { get; set; }

        public ExerciseOperation()
        {

        }

        public ExerciseOperation(int id, DateTime completeDate, int exerciseId) : this()
        {
            Id = id;
            CompleteDate = completeDate;
            ExerciseId = exerciseId;
        }
    }
}
