using Core.Entities.Abstract;

namespace Guide.Entities.Concrete.Exercises
{
    public class ExercisePropertyOption : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ExercisePropertyId { get; set; }
    }
}
