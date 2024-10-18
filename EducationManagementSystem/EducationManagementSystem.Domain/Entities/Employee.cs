using EducationManagementSystem.Domain.CommonEntities;

namespace EducationManagementSystem.Domain.Entities;

public class Employee : BaseEntity
{
    public string FirstName {  get; set; }
    public string LastName { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string MotherName { get; set; }
    public string FatherName { get; set; }
    public string SpouseName { get; set; }
    public string EmailAddress { get; set; }
    public string MobileNumber { get; set; }
    public string ImageUrl { get; set; }
    public string Signature { get; set; }
    public string AlternateMobile {  get; set; }
    public string Nidno { get; set; }
    public string NIdUrl { get; set; }
    public int DesignationId {  get; set; }
    public Designation Designation { get; set; }
    public int DepartmentId { get; set; }
    public Department Department { get; set; }
    public  IList<Address> Address { get; set; } = new List<Address>();
    public IList<AcademicQualification> AcademicQualifications { get; set; } = new List<AcademicQualification>();
}
