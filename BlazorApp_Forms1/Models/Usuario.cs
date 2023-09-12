using System.ComponentModel.DataAnnotations;

namespace BlazorApp_Forms1.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="O nome deve ser informado.")]
        [StringLength(20, ErrorMessage ="O nome não pode exceder 20 caracteres.")]
        public string? Nome { get; set; }
        [Required(ErrorMessage = "O e-mail deve ser informado.")]
        [EmailAddress(ErrorMessage ="Informe um e-mail válido.")]
        public string? Email { get; set; }

        [Range(18, 80, ErrorMessage ="A idade deve estar entre 18 e 80 anos")]
        public int Idade { get; set; }
    }
}
