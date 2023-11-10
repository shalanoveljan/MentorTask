using System.ComponentModel.DataAnnotations;

namespace MentorTemplate.Models
{
    public class Module
    {
        public int Id { get; set; }
        [StringLength(100)]
        public string? Name { get; set; }
        [StringLength(1000)]

        public string? Description { get; set; }
        [StringLength(255)]

        public string? Image { get; set; }

        public int? CourseId { get; set; }

        public Course? Course { get; set;}

    }
}
