using Core.Entities.Abstract;
using Guide.Entities.Constants;
using System;

namespace Guide.Entities.Concrete
{
    public class Aim : IEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public DateTime CreateDate { get; set; }
        public bool IsConvertedToTask { get; set; }
        public AimTimeCategory TimeCategoryId { get; set; }
    }
}
