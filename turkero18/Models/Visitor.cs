using System.ComponentModel.DataAnnotations;

namespace turkero18.Models
{
    public class Visitor
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string VisitorName { get; set; }
        [Required]
        public int VisitorAge { get; set; }

    }
}