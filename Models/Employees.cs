using System.ComponentModel.DataAnnotations;

namespace TshimologongSystem.Models
{
    public class Employees
    {
       [Key]
        public int EmployeeId { get; set; }
        public string EmployeeFirstName { get; set; }
        public string EmployeeLastName { get; set; }

        public int EmployeeAge { get; set; }
        public string DepartmentId { get; set; }
        public string PositionId { get; set; }

        public virtual Department Department { get; set; }
        public virtual Position Position { get; set; }
    }
}
