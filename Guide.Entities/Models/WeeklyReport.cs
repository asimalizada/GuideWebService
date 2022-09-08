using Core.Entities.Abstract;

namespace Guide.Entities.Models
{
    public class WeeklyReport : IModel
    {
        public double Monday { get; set; }
        public double Tuesday { get; set; }
        public double Wednesday { get; set; }
        public double Thursday { get; set; }
        public double Friday { get; set; }
        public double Saturday { get; set; }
        public double Sunday { get; set; }
        public double Overall { get; set; }
    }
}
