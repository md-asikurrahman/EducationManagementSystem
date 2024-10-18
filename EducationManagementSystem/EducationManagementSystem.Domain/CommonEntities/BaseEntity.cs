namespace EducationManagementSystem.Domain.CommonEntities;

public class BaseEntity
{
    public int Id { get; set; }
    public string? CreatedById {  get; set; }
    public string? CreatedBy { get; set; }
    public DateTime CreatedAt { get; set; }
    public string? UpdatedById { get; set; }
    public string? UpdatedBy { get; set; }
    public DateTime? UpdatedAt { get; set; }
    public bool IsActive { get; set; }  
}
