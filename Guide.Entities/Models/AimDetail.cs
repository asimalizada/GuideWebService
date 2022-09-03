using Core.Entities.Abstract;
using Guide.Entities.Constants;
using System;

namespace Guide.Entities.Models
{
    public class AimDetail : IDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string CategoryName { get; set; }
        public DateTime CreateDate { get; set; }
        public AimTimeCategory TimeCategoryId { get; set; }
    }
}
