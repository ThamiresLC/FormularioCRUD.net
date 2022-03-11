using System.ComponentModel.DataAnnotations;

namespace WebMVC.Models
{
    public class Pessoa
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [MinLength(5, ErrorMessage = "É necessário ter mais de 5 dígitos no campo nome")]
        [MaxLength(20, ErrorMessage = "Quantidade máxima de 20 caracteres")]
        public string Nome { get; set; }


        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [Display(Name ="Data de nascimento")]
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
        [MaxLength(8, ErrorMessage = "Quantidade máxima de 8 caracteres")]
        public string Sexo { get; set; }

    }
}
