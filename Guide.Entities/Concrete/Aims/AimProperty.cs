using Core.Entities.Concrete;
using Guide.Entities.Constants;

namespace Guide.Entities.Concrete.Aims
{
    public class AimProperty : Entity
    {
        public string Name { get; set; }
        public AimPropertyType Type { get; set; }

        public AimProperty()
        {

        }

        public AimProperty(int id, string name, AimPropertyType type) : this()
        {
            Id = id;
            Name = name;
            Type = type;
        }
    }
}
