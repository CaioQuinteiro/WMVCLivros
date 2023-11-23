using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WMVCLivros.Models
{
    [Table("Usuarios")]
    public class Usuarios
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID: ")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo Nome é obrigatório")]
        [Display(Name = "Nome: ")]
        [StringLength(70)]
        public required string Nome { get; set; }
        

    }
}
