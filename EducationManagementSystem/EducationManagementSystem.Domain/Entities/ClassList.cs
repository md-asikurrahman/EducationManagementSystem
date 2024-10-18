using EducationManagementSystem.Domain.CommonEntities;

namespace EducationManagementSystem.Domain.Entities;

public class ClassList : BaseEntity
{
    public int AcademicSessionId { get; set; }
    public AcademicSession AcademicSession { get; set; }
    public int EducationLevelId { get; set; }
    public EducationLevel EducationLevel { get; set; }
    public string ClassName { get; set; }
    public string Description { get; set; } 
    public IList<Employee> Employees { get; set; } = new List<Employee>();
}
