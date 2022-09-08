using Core.Entities.Concrete;

namespace Guide.Entities.Concrete.Aims
{
    public class AimPropertyValue : Entity
    {
        public string Value { get; set; }
        public int AimId { get; set; }
        public int PropertyId { get; set; }

        public AimPropertyValue()
        {

        }

        public AimPropertyValue(int id, string value, int aimId, int propertyId) : this()
        {
            Id = id;
            Value = value;
            AimId = aimId;
            PropertyId = propertyId;
        }
    }
}
