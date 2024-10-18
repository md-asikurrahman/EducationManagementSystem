using EducationManagementSystem.Domain.CommonEntities;

namespace EducationManagementSystem.Domain.Entities;

public class EducationLevel : BaseEntity
{
    public string LevelName {  get; set; }
    public string Description { get; set; } = string.Empty;
    public IList<ClassList> ClassList { get; set; } = new List<ClassList>();
}
