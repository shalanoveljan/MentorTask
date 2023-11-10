using NuGet.Protocol.Core.Types;

namespace MentorTemplate.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public IEnumerable<Trainer>? Trainers { get; set; }
    }
}
