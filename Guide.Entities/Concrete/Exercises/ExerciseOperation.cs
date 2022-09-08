using Core.Entities.Concrete;

namespace Guide.Entities.Concrete.Exercises
{
    public class ExerciseOperation : Entity
    {
        public DateTime CompleteDate { get; set; }
        public int ExerciseId { get; set; }
    }
}
