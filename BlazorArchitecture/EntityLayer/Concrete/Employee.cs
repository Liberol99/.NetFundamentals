using EntityLayer.Abstract;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class Employee : IEntity
    {
        [Key]
        public long RecId { get; set; }
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        public bool InUse { get; set; } = true;
        public string Name { get; set; } = string.Empty;
        public string EMail { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;
        public string Price { get; set; } = string.Empty;
    }
}