using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WMVCLivros.Models
{
    [Table("Vendas")]
    public class Vendas
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Display(Name = "ID: ")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo DataVenda é obrigatório")]
        [Display(Name = "Data da Venda: ")]
        [DataType(DataType.DateTime)]
        public DateTime DataVenda { get; set; }

        [Required(ErrorMessage = "Campo Quantidade é obrigatório")]
        [Display(Name = "Quantidade: ")]
        public int Qtde { get; set; }

        [Display(Name = "Livro: ")]
        public int LivroId { get; set; }
        [ForeignKey("LivroId")]
        public required Livros Livros { get; set; }

        [Display(Name = "Cliente: ")]
        public int ClienteId { get; set; }
        [ForeignKey("ClienteId")]
        public required Clientes Clientes { get; set; }
    }
}
