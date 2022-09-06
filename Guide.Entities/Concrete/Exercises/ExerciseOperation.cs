using Core.Entities.Abstract;

namespace Guide.Entities.Concrete.Exercises
{
    public class ExerciseOperation : IEntity
    {
        public int Id { get; set; }
        public DateTime CompleteDate { get; set; }
        public int ExerciseId { get; set; }
    }
}
