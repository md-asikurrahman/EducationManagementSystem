using EducationManagementSystem.Domain.CommonEntities;

namespace EducationManagementSystem.Domain.Entities;

public class StudentClass : BaseEntity
{
    public int StudentId { get; set; }
    public Student Student { get; set; }
}
