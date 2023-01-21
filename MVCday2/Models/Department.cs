using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MVCday2.Models
{
    public class Department
    {
        [Key]
        public int Number { get; set; }
        public string Name { get; set; }
        public List<Location>? locations { get; set; }
        public List<Project>? projects { get; set; }
    }
}
