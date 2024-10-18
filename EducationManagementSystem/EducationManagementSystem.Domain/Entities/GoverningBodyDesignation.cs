using EducationManagementSystem.Domain.CommonEntities;

namespace EducationManagementSystem.Domain.Entities;

public class GoverningBodyDesignation : BaseEntity
{
    public string DesignationName { get; set; }
    public string Description { get; set; }
    public IList<GoverningBody> GoverningBodies { get; set; }
}
