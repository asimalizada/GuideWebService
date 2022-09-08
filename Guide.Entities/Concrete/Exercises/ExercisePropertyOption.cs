using Core.Entities.Concrete;

namespace Guide.Entities.Concrete.Exercises
{
    public class ExercisePropertyOption : Entity
    {
        public string Name { get; set; }
        public int ExercisePropertyId { get; set; }

        public ExercisePropertyOption()
        {

        }

        public ExercisePropertyOption(int id, string name, int exercisePropertyId) : this()
        {
            Id = id;
            Name = name;
            ExercisePropertyId = exercisePropertyId;
        }
    }
}
