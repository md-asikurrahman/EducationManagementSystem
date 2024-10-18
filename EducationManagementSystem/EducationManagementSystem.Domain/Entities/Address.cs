using EducationManagementSystem.Domain.CommonEntities;
using EducationManagementSystem.Domain.Enum;

namespace EducationManagementSystem.Domain.Entities;

public class Address : BaseEntity
{
    public string CareOff {  get; set; }
    public string HouseNo { get; set; }
    public string RoadNo { get; set; }  
    public string AddressName { get; set; }
    public string PostOffice { get; set; }
    public int PostCode { get; set; }
    public int? CountryId { get; set; }
    public int? DivisionId { get; set; }
    public int? DistrictId { get; set; }
    public int? UpazillaId { get; set; }
    public AddressType AddressType { get; set; }
    public int EmployeeId { get; set; }
    public Employee Employee { get; set; }
}
