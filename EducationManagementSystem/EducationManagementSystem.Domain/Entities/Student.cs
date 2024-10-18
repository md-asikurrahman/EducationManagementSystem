using EducationManagementSystem.Domain.CommonEntities;

namespace EducationManagementSystem.Domain.Entities;

public class Student : BaseEntity
{
    public string Name { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string Fathername { get; set; }
    public string MotherName { get; set; }
    public string MobileNo { get; set; }
    public string FatherOccupation { get; set; }
    public string MotherOccupation { get; set; }
    public string BirthCertificateNo { get; set; }
    public string BirthUrl { get; set; }
    public string ImageUrl { get; set; }
    public int AcademicSessionId { get; set; }
    public AcademicSession AcademicSession { get; set; }
    public IList<Address> AddressList { get; set; }
    public IList<StudentClass> StudentClass { get; set; } = new List<StudentClass>();
}
