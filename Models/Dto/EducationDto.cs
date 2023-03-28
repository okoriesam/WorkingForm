using System.ComponentModel.DataAnnotations;

namespace MetrosoftForm.Models.Dto
{
    public class EducationDto
    {
        [Required]
        public PrimaryEducation Primaryeducation { get; set; }
        [Required]
        public SecondaryEducation Secondaryeducation { get; set; }
        [Required]
        public TertiaryEducation Tertiaryeducation { get; set; }
        [Required]
        public Employee Employee { get; set; }
        public Guid EmployeeId { get; set; }


        public class PrimaryEducation
        {
            [Required]
            public string SchoolAttended { get; set; }
            [Required]
            public string Subject { get; set; }
            [Required]
            public DateTime StartYear { get; set; }
            [Required]
            public DateTime EndYear { get; set; }
        }
        public class SecondaryEducation
        {
            [Required]
            public string SchoolAttended { get; set; }
            [Required]
            public string Subject { get; set; }
            [Required]
            public DateTime StartYear { get; set; }
            [Required]
            public DateTime EndYear { get; set; }
        }

        public class TertiaryEducation
        {
            public string SchoolAttended { get; set; }
            public string Subject { get; set; }
            public DateTime StartYear { get; set; }
            public DateTime EndYear { get; set; }
        }

    }
}
