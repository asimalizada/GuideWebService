using Core.Entities.Abstract;

namespace Guide.Entities.Concrete.Exercises
{
    public class ExercisePropertyValue : IEntity
    {
        public int Id { get; set; }
        public string Value { get; set; }
        public int ExerciseId { get; set; }
        public int PropertyId { get; set; }
    }
}
