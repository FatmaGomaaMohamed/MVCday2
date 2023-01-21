using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCday2.Models
{
    public class Project
    {
        [Key]
        public int Number { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public List<Works_On>? works_Ons { get; set; }
        public Department? department { get; set; }
        [ForeignKey("department")]
        public int? DepartmentId { get; set; }
    }
}
