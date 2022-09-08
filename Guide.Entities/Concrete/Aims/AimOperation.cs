using Core.Entities.Concrete;

namespace Guide.Entities.Concrete.Aims
{
    public class AimOperation : Entity
    {
        public DateTime CompleteDate { get; set; }
        public int AimId { get; set; }
    }
}
