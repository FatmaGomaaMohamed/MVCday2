using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MVCday2.Models
{
    public class Employee
    {
        [Key]
        public int SSN { get; set; }
        [StringLength(20)]
        public string FirstName { get; set; }
        [StringLength(20)]
        public string LastName { get; set; }
        [StringLength(50)]
        public string Address { get; set; }
        [Column(TypeName ="money")]
        public double Salary { get; set; }
        [Column(TypeName ="date")]
        public DateTime Bdate { get; set; }
        [StringLength(20)]
        public string Sex { get; set; }
        public Employee? Supervisor { get; set; }
        public List<Employee>? employees { get; set; }
        public List<Dependent>? dependents { get; set; }
        public List<Works_On>? works_Ons { get; set; }
    }
}
