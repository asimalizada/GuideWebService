using Core.Entities.Concrete;
using Guide.Entities.Constants;

namespace Guide.Entities.Concrete.Aims
{
    public class Aim : Entity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreateDate { get; set; }
        public bool IsConvertedToExercise { get; set; }
        public AimTimeCategory TimeCategoryId { get; set; }

        public Aim()
        {

        }

        public Aim(int id, string title, string description, DateTime createDate, bool isConvertedToExercise, AimTimeCategory timeCategoryId) : this()
        {
            Id = id;
            Title = title;
            Description = description;
            CreateDate = createDate;
            IsConvertedToExercise = isConvertedToExercise;
            TimeCategoryId = timeCategoryId;
        }
    }
}
