using Core.Entities.Abstract;

namespace Guide.Entities.Concrete
{
    public class ExerciseOperation : IEntity
    {
        public int Id { get; set; }
        public DateTime CompleteDate { get; set; }
        public int TaskId { get; set; }
    }
}
