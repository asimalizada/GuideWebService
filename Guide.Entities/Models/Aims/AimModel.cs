using Core.Entities.Abstract;
using Guide.Entities.Concrete.Aims;
using Guide.Entities.Constants;
using System;

namespace Guide.Entities.Models.Aims
{
    public class AimModel : IModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreateDate { get; set; }
        public AimTimeCategory TimeCategoryId { get; set; }
        public List<AimPropertyValue> Properties { get; set; }
    }
}
