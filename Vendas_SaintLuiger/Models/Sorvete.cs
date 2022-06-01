using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Vendas_SaintLuiger.Models
{
    [Table("Sorvetes")]
    public class Sorvete
    {
        [Key]
        public int SorveteId { get; set; }

        [Required(ErrorMessage = "Informe do sorvete deve ser informado.")]
        [Display(Name = "Nome do Sorvete")]
        [StringLength(80, MinimumLength = 10, ErrorMessage ="O {0} deve ter no minímo {1} e no máximo {2}")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "A descrição do sorvete deve ser informado.")]
        [Display(Name = "Descrição do Sorvete")]
        [MinLength(20,ErrorMessage = "A descrição deve ter no minímo {0} caracteres.")]
        [MaxLength(200,ErrorMessage = "A descrição deve ter no máximo {0} caracteres")]
        public string DescricaoCurta { get; set; }

        [Required(ErrorMessage = "A descrição detalhada do sorvete deve ser informado.")]
        [Display(Name = "Descrição detalhada do Sorvete")]
        [MinLength(20, ErrorMessage = "A descrição deve ter no minímo {0} caracteres.")]
        [MaxLength(200, ErrorMessage = "A descrição deve ter no máximo {0} caracteres")]
        public string DescricaoDetalhada { get; set; }
        
        [Required(ErrorMessage = "Informe o preço do Sorvete")]
        [Display(Name ="Preço")]
        [Column(TypeName = "decimal(10,2)")]
        [Range(1,999.99,ErrorMessage ="O preço deve estar entre 1 e 999.99")]
        public decimal Preco{ get; set; }
        [Display(Name = "Caminho imagem Normal")]
        [StringLength(200, ErrorMessage = "O {0} deve ter no máximo {1}")]
        public string ImagemUrl { get; set; }
        [Display(Name = "Caminho imagem miniatura")]
        [StringLength(200, ErrorMessage = "O {0} deve ter no máximo {1}")]
        public string ImagemThumbnailUrl { get; set; }
        [Display(Name = "Preferido?")]
        public bool IsSorvetePreferido { get; set; }

        [Display(Name = "Estoque")]
        public bool EmEstoque { get; set; }
        public int CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }


    }
}
