using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MetrosoftForm.Models
{
    public class Reference
    {
        [Column("ReferenceId")]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime Years { get; set; }
        public string Address { get; set; }
        public Guid EmployeeId { get; set; }
        public Employee Employee { get; set; }
    }
}
