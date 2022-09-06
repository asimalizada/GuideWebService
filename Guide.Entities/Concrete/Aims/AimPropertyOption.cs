using Core.Entities.Abstract;

namespace Guide.Entities.Concrete.Aims
{
    public class AimPropertyOption : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int AimPropertyId { get; set; }
    }
}
