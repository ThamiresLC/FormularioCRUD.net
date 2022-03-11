using System.ComponentModel.DataAnnotations;

namespace WebMVC.Models
{
    public class Atuacao
    {
        public int Id  { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [MinLength(2, ErrorMessage = "Por favor, digite seu ramo de atuação.")]
        [MaxLength(20, ErrorMessage = "Digite até 20 caracteres.")]
        public string Descricao { get; set; }
    }
}
