using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MentorTemplate.Models
{
    public class Course
    {

        public int Id { get; set; }
        [StringLength(100)]
        public string? Title { get; set; }
        [StringLength(1000)]

        public string? Image { get; set; }
        [StringLength(1000)]
        public string? Description { get; set; }
        [Column(TypeName = "smallmoney")]
        public double? Price { get; set; }
        public byte? Seat { get; set; }
        [StringLength(100)]
        public string? Schedule { get; set; }

        public int? TrainerId { get; set; }

        public Trainer? Trainer { get; set; }

        public IEnumerable<Module>? Modules { get; set; }
    }
}
