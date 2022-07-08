using System.ComponentModel.DataAnnotations;

namespace TshimologongSystem.Data
{
    public class Roles
    {
        [Key]
        public string RoleId { get; set; }
        public string RoleName { get; set; }
        

    }
}
