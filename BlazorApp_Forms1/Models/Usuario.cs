using System.ComponentModel.DataAnnotations;

namespace BlazorApp_Forms1.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        [Required]
        public string? Nome { get; set; }
        [EmailAddress]
        public string? Email { get; set; }

        [Range(18, 80, ErrorMessage ="A idade deve estar entre 18 e 80 anos")]
        public int Idade { get; set; }
    }
}
