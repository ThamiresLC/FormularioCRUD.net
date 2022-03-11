using System.ComponentModel.DataAnnotations;

namespace WebMVC.Models
{
    public class Cliente
    {
        public int Id { get; set; }

        [Display(Name = "Escolha o tipo de cadastro que deseja utilizar")]
        public PessoaTipoEnum PessoaTipo { get; set; }


        [MaxLength(20, ErrorMessage = "Quantidade máxima de 20 caracteres")]
        public string? Nome { get; set; } = null!;

        public string? CPF { get; set; }

      
        [MaxLength(30, ErrorMessage = "Quantidade máxima de 30 caracteres")]
        [Display(Name = "Razão Social")]
        public string? RazaoSocial { get; set; } = null!;

     
        [MaxLength(30, ErrorMessage = "Quantidade máxima de 30 caracteres")]

        [Display(Name = "Nome Fantasia")]
        public string? NomeFantasia { get; set; } = null!;


        public string? CNPJ { get; set; } = null!;


        [Display(Name = "Inscrição Estadual")]
        public string? InscricaoEstadual { get; set; } = null!;


        [Display(Name = "Data de nascimento")]
        [DataType(DataType.Date)]
        public DateTime? DataDeNascimento { get; set; } = null!;

        [MinLength(5, ErrorMessage = "É necessário ter mais de 5 dígitos")]
        [MaxLength(15, ErrorMessage = "Quantidade máxima de 15 caracteres")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [Display(Name = "E-mail")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }


        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [DataType(DataType.PhoneNumber)]
        public string Celular { get; set; }


        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [DataType(DataType.PostalCode)]
        public string CEP { get; set; }


        [MaxLength(10, ErrorMessage = "Quantidade máxima de 10 caracteres")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Logradouro { get; set; }

        [MaxLength(5, ErrorMessage = "Quantidade máxima de 5 caracteres")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Numero { get; set; }

        [MaxLength(10, ErrorMessage = "Quantidade máxima de 10 caracteres")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Bairro { get; set; }

        [MaxLength(10, ErrorMessage = "Quantidade máxima de 10 caracteres")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string Cidade { get; set; }

        [MaxLength(2, ErrorMessage = "Quantidade máxima de 2 caracteres")]
        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public string UF { get; set; }


        [DataType(DataType.ImageUrl)]
        [Display(Name = "Foto de Perfil")]
        public string? FotoPerfil { get; set; } = null!;

        [Display(Name = "Atuação")]
        public int? AtuacaoId { get; set; } = null!;

        [ScaffoldColumn(false)]
        public Atuacao? Atuacao { get; set; } = null!;

    }

}

