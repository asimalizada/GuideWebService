using Core.Entities.Abstract;
using Guide.Entities.Constants;

namespace Guide.Entities.Models.ApiModels
{
    public class AimAddModel : IAddModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreateDate { get; set; }
        public AimTimeCategory TimeCategoryId { get; set; }
    }
}
