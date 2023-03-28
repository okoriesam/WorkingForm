using System.ComponentModel.DataAnnotations;

namespace MetrosoftForm.Models
{
    public class Education
    {
        public Guid Id { get; set; }
        public PrimaryEducation Primaryeducation { get; set; }
        public SecondaryEducation Secondaryeducation { get; set;}
        public TertiaryEducation Tertiaryeducation { get; set;}
        public Employee Employee { get; set; }
        public Guid EmployeeId { get; set; } 


        public class PrimaryEducation
        {
            public Guid Id { get; set; }
            public string PrimarySchoolAttended { get; set; }
            public string Subject { get; set; }
            public DateTime StartYear { get; set; }
            public DateTime EndYear { get; set; }
        }
        public class SecondaryEducation
        {
            public Guid Id { get; set; }
            public string SecondarySchoolAttended { get; set; }
            public string Subject { get; set; }
            public DateTime StartYear { get; set; }
            public DateTime EndYear { get; set; }
        }

        public class TertiaryEducation
        {
            public Guid Id { get; set; }
            public string TertiarySchoolAttended { get; set; }
            public string Subject { get; set; }
            public DateTime StartYear { get; set; }
            public DateTime EndYear { get; set; }
        }
    }
}
