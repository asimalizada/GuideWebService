using Core.Entities.Concrete;

namespace Guide.Entities.Concrete.Aims
{
    public class AimPropertyOption : Entity
    {
        public string Name { get; set; }
        public int AimPropertyId { get; set; }

        public AimPropertyOption()
        {

        }

        public AimPropertyOption(int id, string name, int aimPropertyId) : this()
        {
            Id = id;
            Name = name;
            AimPropertyId = aimPropertyId;
        }
    }
}
