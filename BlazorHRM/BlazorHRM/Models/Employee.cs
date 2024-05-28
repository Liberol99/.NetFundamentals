namespace BlazorHRM.Models
{
    public class Employee
    {
        public long RecId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Mail { get; set; } = string.Empty;
        public decimal Price { get; set; }
    }
}
