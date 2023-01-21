using System.ComponentModel.DataAnnotations.Schema;

namespace MVCday2.Models
{
    public class Works_On
    {
        public int Hours { get; set; }
        public virtual Employee? emp { get; set; }
        [ForeignKey("emp")]
        public int? EmpId { get; set; }
        public virtual Project? pro { get; set; }
        [ForeignKey("pro")]
        public int? proNumber { get; set; }

    }
}
