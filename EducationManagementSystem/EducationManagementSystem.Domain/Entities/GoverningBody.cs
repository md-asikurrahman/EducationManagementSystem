using EducationManagementSystem.Domain.CommonEntities;

namespace EducationManagementSystem.Domain.Entities;

public class GoverningBody : BaseEntity
{
    public int GoverningBodyDesignationId { get; set; }
    public GoverningBodyDesignation GoverningBodyDesignation { get; set; }
    public string Name { get; set; }
    public string MobileNo { get; set; }
    public string ImageUrl { get; set; }
    public DateTime DateOfBirth { get; set; }
}
