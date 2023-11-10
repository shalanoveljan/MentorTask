using System.ComponentModel.DataAnnotations;

namespace MentorTemplate.Models
{
    public class Trainer
    {
        public int Id { get; set; }
        [StringLength(100)]

        public string Name { get; set; }
        [StringLength(100)]
        public string Surname { get; set; }
        [StringLength(1000)]

        public string? Description { get; set; }
        [StringLength(255)]

        public string? Image { get; set; }
        [StringLength(255)]

        public string? TwitterUrl { get; set; }
        [StringLength(255)]

        public string? FacebookUrl { get; set; }
        [StringLength(255)]

        public string? InstagramUrl { get; set; }
        [StringLength(255)]

        public string? LinkedinUrl { get; set; }

        public int? CategoryId { get; set; }

        public Category? Category { get; set; }

        public IEnumerable<Course>? Courses { get; set; }


    }
}
