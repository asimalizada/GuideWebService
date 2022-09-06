using Core.Entities.Abstract;
using Guide.Entities.Constants;

namespace Guide.Entities.Concrete.Aims
{
    public class AimProperty : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public AimPropertyType Type { get; set; }
    }
}
