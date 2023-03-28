using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Cryptography.Xml;

namespace MetrosoftForm.Models
{
    public class Employee
    {
        [Column("EmployeeId")]
        public Guid Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Surname { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        [StringLength(50)]
        public string OtherName { get; set; }
        [Required]
        public string ImageUrl { get; set; }
        [Required]
        public string HomeAddress { get; set; }
        [Required]
        public string TelePhone { get; set; }
        [Required]
        public string ContactAddress { get; set; }
        [Required]
        public string ContactPhone { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }
        [Required]
        public string Origin { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string MaritalStatus { get; set; }
        [Required]
        public string Nationality { get; set; }
        [Required]
        public string NameOfSpouse { get; set; }
        [Required]
        public string SpouseProfession { get; set; }
        [Required]
        public string NameOfChildren { get; set; }
        [Required]
        public string NextOfKin { get; set; }
        [Required]
        public string NextOfKinProfession { get; set; }
        [Required]
        public string Relationship { get; set; }
        [Required]
        public string Emergency { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string PersonPhoneNumber { get; set; }
        [Required]
        [EmailAddress]
        public string PersonEmail { get; set; }
        [Required]
        public string FatherFullName { get; set; }
        [Required]
        public string FatherHomeTown { get; set; }
        [Required]
        public string FatherCurrentAddres { get; set; }
        [Required]
        public string MotherFullName { get; set; }
        [Required]
        public string MotherHomeTown { get; set; }
        [Required]
        public string MotherCurrentAddress { get; set; }
        public string ProfessionalQualification { get; set; }
        public string Project { get; set; }
        [Required]
        public string MedicalHistory { get; set; }
        public string Indebt { get; set; }
        public int IndebtAmount { get; set; }
        [Required]
        public string crime { get; set; }
        [Required]
        public DateTime CrimeDate { get; set; }
        [Required]
        public string NameOfLawEnforcement { get; set; }
        [Required]
        public string PenaltyImpose { get; set; }
        [Required]
        public string SocialActivity { get; set; }
        [Required]
        public string Leisure { get; set; }
        [Required]
        public string Sporting { get; set; }
        [Required]
        public string General { get; set; }
        [Required]
        public string Briefly { get; set; }
        [Required]
        public string Addictional { get; set; }
        public DateTime DateOfResumption { get; set; }
        public string NoticePeriod { get; set; }
        public int RequiredSalary { get; set; }
        public ICollection<Experience> Experience { get; set; }
        public ICollection<Reference> Reference { get; set; }
        public ICollection<Education> Educations { get; set; }
    }
}
