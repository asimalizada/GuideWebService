using Core.Entities.Concrete;

namespace Guide.Entities.Concrete.Exercises
{
    public class ExercisePropertyOption : Entity
    {
        public string Name { get; set; }
        public int ExercisePropertyId { get; set; }
    }
}
