using EducationManagementSystem.Domain.CommonEntities;

namespace EducationManagementSystem.Domain.Entities;

public class Designation : BaseEntity
{
    public string DesignationName { get; set; }
    public string Description { get; set; }
    public IList<Employee> Employees { get; set; }
}
