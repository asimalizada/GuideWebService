using Core.Entities.Abstract;

namespace Guide.Entities.Concrete.Aims
{
    public class AimPropertyValue : IEntity
    {
        public int Id { get; set; }
        public string Value { get; set; }
        public int AimId { get; set; }
        public int PropertyId { get; set; }
    }
}
