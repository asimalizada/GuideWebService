using Core.Entities.Concrete;

namespace Guide.Entities.Concrete.Exercises
{
    public class ExercisePropertyValue : Entity
    {
        public string Value { get; set; }
        public int ExerciseId { get; set; }
        public int PropertyId { get; set; }
    }
}
