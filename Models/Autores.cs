using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WMVCLivros.Models
{
    [Table("Autores")]
    public class Autores
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID: ")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo Nome é obrigatório")]
        [Display(Name = "Nome: ")]
        [StringLength(70)]
        public required string Nome { get; set; }

        [Required(ErrorMessage = "Campo Idade é obrigatório")]
        [Display(Name = "Idade: ")]
        public int Data { get; set; }

        [Required(ErrorMessage = "Campo Nacionalidade é obrigatório")]
        [Display(Name = "Nacionalidade: ")]
        [StringLength(40)]
        public required string Nacionalidade { get; set; }
    }
}
