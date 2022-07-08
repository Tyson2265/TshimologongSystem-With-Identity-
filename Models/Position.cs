namespace TshimologongSystem.Models
{
    public class Position
    {

        public string PositionId { get; set; }

        public string PositionName { get; set; }

        public virtual ICollection<Employees> employees { get; set; }


    }
}
