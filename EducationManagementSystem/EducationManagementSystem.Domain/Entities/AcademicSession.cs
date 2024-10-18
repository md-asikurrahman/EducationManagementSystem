using EducationManagementSystem.Domain.CommonEntities;

namespace EducationManagementSystem.Domain.Entities;

public class AcademicSession : BaseEntity
{
    public string SessionName { get; set; }
    public string Description { get; set; }
    public IList<Student> Students { get; set; } = new List<Student>();
}
