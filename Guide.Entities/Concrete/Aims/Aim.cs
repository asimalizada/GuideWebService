using Core.Entities.Concrete;
using Guide.Entities.Constants;

namespace Guide.Entities.Concrete.Aims
{
    public class Aim : Entity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreateDate { get; set; }
        public bool IsConvertedToTask { get; set; }
        public AimTimeCategory TimeCategoryId { get; set; }
    }
}
