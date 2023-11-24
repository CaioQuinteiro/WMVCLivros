using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WMVCLivros.Models
{
    [Table("Clientes")]
    public class Clientes
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
        [Display(Name = "Final do Celular(4): ")]
        public int Celular { get; set; }

    }
}
