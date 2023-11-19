using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WMVCLivros.Models
{
    [Table("Editoras")]
    public class Editoras
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID: ")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo Nome é obrigatório")]
        [Display(Name = "Nome: ")]
        [StringLength(50)]
        public required string Nome { get; set; }

        [Required(ErrorMessage = "Campo Localização é obrigatório")]
        [Display(Name = "Localização: ")]
        [StringLength(100)]
        public required string Localizacao { get; set; }

        [Required(ErrorMessage = "Campo Fundação é obrigatório")]
        [Display(Name = "Data Fundação: ")]
        [DataType(DataType.DateTime)]
        public DateTime Fundacao { get; set; }

    }
}

