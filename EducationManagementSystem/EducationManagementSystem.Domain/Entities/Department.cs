using EducationManagementSystem.Domain.CommonEntities;

namespace EducationManagementSystem.Domain.Entities;

public class Department : BaseEntity
{
    public string DepartmentName { get; set; }
    public string DepartmentDescription { get; set; }
    public IList<Employee> Employees { get; set; }
}
