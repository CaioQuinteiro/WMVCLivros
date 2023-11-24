using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WMVCLivros.Models
{
    [Table("Livros")]
    public class Livros
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID: ")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo Nome é obrigatório")]
        [StringLength(50)]
        [Display(Name = "Nome: ")]
        public required string Nome { get; set; }

        [Required(ErrorMessage = "Campo valor é obrigatório")]
        [DisplayFormat(DataFormatString = "{0:C2}")]
        [Display(Name = "Valor: ")]
        public float Valor { get; set; }

        [Required(ErrorMessage = "Campo quantidade é obrigatório")]
        [Display(Name = "Quantidade: ")]
        public int Qtde { get; set; }

        [Required(ErrorMessage = "Campo é obrigatório")]
        public int AnoDePublicacao { get; set; }

        [Display(Name = "Autor(a): ")]
        public int AutoresID { get; set; }
        [ForeignKey("AutoresID")]
        public required Autores Autores { get; set; }

        [Display(Name = "Editora: ")]
        public int EditoraID { get; set; }
        [ForeignKey("EditoraID")]
        public required Editoras Editoras { get; set; }
    }
}
