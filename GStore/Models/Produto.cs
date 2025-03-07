using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GStore.Models;

[Table("produto")]
public class Produto
{
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "Por favor, informe a Categoria")]
    public int CategoriaId { get; set; }
    [ForeignKey("CategoriaId")]
    public Categoria Categoria { get; set; }
    
    [Required(ErrorMessage = "Por favor, informe o Nome")]
    [StringLength(60, ErrorMessage = "O nome deve possuir no maximo 60 caracteres.")]
    public string Nome { get; set; }
    
    [Display(Name = "Descrição", Prompt = "Descrição")]
    [StringLength(1000, ErrorMessage = "A descrição deve posssuir no máximo 1000 caracteres.")]
    public string Descricao { get; set; }
    
    [Display(Name = "Quantidade em Estoque")]
    [Range(0, int.MaxValue)]
    [Required(ErrorMessage = "Por favor, informe a quantidade de Estoque")]
    public int QtdeEstoque { get; set; }

    [Display(Name = "Valor de Custo")]
    [Range(0, double.MaxValue)]
    [Column(TypeName = "numeric(10,2)")]
    public decimal ValorCusto { get; set; }
    
    [Display(Name = "Valor de Venda")]
    [Range(0, double.MaxValue)]
    [Column(TypeName = "numeric(10,2)")]
    public decimal ValorVenda { get; set; }

    public bool Destaque { get; set; }

    public List<ProdutoFoto> Fotos { get; set; }

}