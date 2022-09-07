using Core.Entities.Abstract;
using Guide.Entities.Constants;

namespace Guide.Entities.Models.ApiModels
{
    public class AimUpdateModel : IUpdateModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreateDate { get; set; }
        public bool IsConvertedToTask { get; set; }
        public AimTimeCategory TimeCategoryId { get; set; }
    }
}
