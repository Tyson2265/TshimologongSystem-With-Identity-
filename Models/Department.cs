using System.ComponentModel.DataAnnotations;

namespace TshimologongSystem.Models
{
    public class Department
    {
        [Key]
        public string DepartmentId { get; set; }
        public string DepartmentName { get; set; }

        public virtual ICollection<Employees> employees { get; set; }
    }
}
