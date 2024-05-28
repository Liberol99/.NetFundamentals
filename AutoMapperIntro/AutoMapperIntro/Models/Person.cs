using System.ComponentModel.DataAnnotations;

namespace AutoMapperIntro.Models
{
    public class Person
    {
        [Key]
        public long RecId { get; set; }
        public int Age { get; set; }
        public string Name { get; set; } = string.Empty;
        public string RoleName { get; set; } = "User";
    }
}
