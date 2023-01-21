using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MVCday2.Models
{
    public class Location
    {
        public string? location { get; set; }
        public Department? department { get; set; }
        [ForeignKey("department")]
        public int deptNumber { get; set; }
    }
}
