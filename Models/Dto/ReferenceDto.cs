using System.ComponentModel.DataAnnotations;

namespace MetrosoftForm.Models.Dto
{
    public class ReferenceDto
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public DateTime Years { get; set; }
        [Required]
        public string Address { get; set; }
        public Guid EmployeeId { get; set; }
        public Employee Employee { get; set; }
    }
}
