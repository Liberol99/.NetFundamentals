using System.ComponentModel.DataAnnotations;

namespace AutoMapperIntro.Models
{
    public class Customer
    {
        [Key]
        public long RecId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Company { get; set; } = string.Empty;
    }
}
