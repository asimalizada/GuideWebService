using Core.Entities.Abstract;
using Guide.Entities.Constants;

namespace Guide.Entities.Concrete.Exercises
{
    public class ExerciseProperty : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ExercisePropertyType Type { get; set; }
    }
}
