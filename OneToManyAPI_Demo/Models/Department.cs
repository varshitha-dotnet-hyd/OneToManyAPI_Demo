using System.ComponentModel.DataAnnotations;

namespace OneToManyAPI_Demo.Models
{
    public class Department
    {
        [Key]
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }
        public ICollection<Employee>? Employees { get; set; }
    }
}
