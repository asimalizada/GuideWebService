using Core.Entities.Abstract;
using System;

namespace Guide.Entities.Concrete
{
    public class AimCategory : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
