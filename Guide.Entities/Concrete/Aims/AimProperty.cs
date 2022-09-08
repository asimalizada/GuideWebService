using Core.Entities.Concrete;
using Guide.Entities.Constants;

namespace Guide.Entities.Concrete.Aims
{
    public class AimProperty : Entity
    {
        public string Name { get; set; }
        public AimPropertyType Type { get; set; }
    }
}
