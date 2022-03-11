using System.ComponentModel.DataAnnotations;

namespace WebMVC.Models
{
    public class Funcionario
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [MinLength(2, ErrorMessage = "Por favor, digite o seu cargo.")]
        [MaxLength(20, ErrorMessage ="Digite até 20 caracteres." )]
        [Display(Name="Cargo")]
        public string Cargo { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [MinLength(3, ErrorMessage = "Por favor, digite o seu nome.")]
        [MaxLength(20, ErrorMessage = "Digite até 20 caracteres.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [Display(Name = "Data de nascimento")]
        [DataType(DataType.Date)]
        public DateTime DataDeNascimento { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [DataType(DataType.PhoneNumber)]
        public string Telefone { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [Display(Name = "E-mail")]
        [DataType(DataType.EmailAddress)]
        [MaxLength(20, ErrorMessage = "Quantidade máxima de 20 caracteres")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string RG { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string CPF { get; set; }

    }
}
