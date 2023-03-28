using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MetrosoftForm.Models
{
    public class Experience
    {
        [Column("ExperenceId")]
        public Guid Id { get; set; }
        [Required]
        public string Period { get; set; }
        [Required]
        public string Organisation { get; set; }
        [Required]
        public double Salary { get; set; }
        [Required]
        public string ReasonForLeaving { get; set; }
        public Employee Employee { get; set; }
        public Guid EmployeeId { get; set; }   
    }
}
