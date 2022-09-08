using Core.Entities.Concrete;

namespace Guide.Entities.Concrete.Exercises
{
    public class ExercisePropertyValue : Entity
    {
        public string Value { get; set; }
        public int ExerciseId { get; set; }
        public int PropertyId { get; set; }

        public ExercisePropertyValue()
        {

        }

        public ExercisePropertyValue(int id, string value, int exerciseId, int propertyId) : this()
        {
            Id = id;
            Value = value;
            ExerciseId = exerciseId;
            PropertyId = propertyId;
        }
    }
}
