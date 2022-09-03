using Core.Entities.Abstract;

namespace Guide.Entities.Concrete
{
    public class ExerciseCategory : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
