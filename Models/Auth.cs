using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WMVCLivros.Models
{
    [Table("Auth")]
    public class Auth
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID: ")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo Nome é obrigatório")]
        [Display(Name = "Nome: ")]
        [StringLength(70)]
        public required string Nome { get; set; }

        [Required(ErrorMessage = "Campo Email é obrigatório")]
        [Display(Name = "Email: ")]
        [StringLength(100)]
        public required string Email { get; set; }

        [Required(ErrorMessage = "Campo Celular é obrigatório")]
        [Display(Name = "Senha: ")]
        public int Senha { get; set; }

    }
}
