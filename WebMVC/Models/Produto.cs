using System.ComponentModel.DataAnnotations;

namespace WebMVC.Models
{
    public class Produto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [MinLength(2, ErrorMessage = "Por favor, digite o seu cargo.")]
        [MaxLength(30, ErrorMessage = "Digite até 30 caracteres.")]
        [Display(Name = "Itens")]
        public string Item { get; set; }

        [MinLength(1, ErrorMessage = "Por favor, digite o seu cargo.")]
        [MaxLength(8000, ErrorMessage = "Digite até 8000 caracteres.")]
        public string Descricao { get; set; }

        [MinLength(2, ErrorMessage = "Por favor, digite o seu cargo.")]
        [MaxLength(20, ErrorMessage = "Digite até 20 caracteres.")]
        public string Cor { get; set; }

        [MinLength(2, ErrorMessage = "Por favor, digite o seu cargo.")]
        [MaxLength(20, ErrorMessage = "Digite até 20 caracteres.")]
        public double Tamanho { get; set; }

        [MinLength(2, ErrorMessage = "Por favor, digite o seu cargo.")]
        [MaxLength(10, ErrorMessage = "Digite até 10 caracteres.")]
        public double Peso { get; set; }


    }
}
