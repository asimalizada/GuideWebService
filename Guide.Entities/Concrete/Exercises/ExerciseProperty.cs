using Core.Entities.Concrete;
using Guide.Entities.Constants;

namespace Guide.Entities.Concrete.Exercises
{
    public class ExerciseProperty : Entity
    {
        public string Name { get; set; }
        public ExercisePropertyType Type { get; set; }

        public ExerciseProperty()
        {

        }

        public ExerciseProperty(int id, string name, ExercisePropertyType type) : this()
        {
            Id = id;
            Name = name;
            Type = type;
        }
    }
}
