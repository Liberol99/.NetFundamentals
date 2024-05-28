using System.ComponentModel.DataAnnotations;

namespace BlazorEditForm.Models
{
    public class Character
    {
        [Required, Range(1,int.MaxValue,ErrorMessage ="Kayıt numarası 1'den küçük olamaz !")]
        public int Id { get; set; }

        [Required(ErrorMessage ="Karakter adı girin !")]
        public string Name { get; set; } = string.Empty;
        public string Bio { get; set; } = string.Empty;
        public DateTime BirthDate { get; set; } = DateTime.Now;
        public string Image { get;set; } = string.Empty;
        public int TeamId { get; set; } = 1;
        public int DifficultyId { get; set; } = 1;
        public bool IsReadyToFight { get; set; } = true;
    }
}
