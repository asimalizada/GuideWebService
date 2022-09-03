using Core.Entities.Abstract;
using System;

namespace Guide.Entities.Concrete
{
    public class AimOperation : IEntity
    {
        public int Id { get; set; }
        public DateTime CompleteDate { get; set; }
        public int AimId { get; set; }
    }
}
