using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConstructionAdmin.Models
{
    public class Item : Entity
    {
        [Display(Name = "Fornecedor")]
        public Guid FornecedorId { get; set; }
        public Guid? StockId { get; set; }
        public Guid? RequisicaoId { get; set; }

        [Display(Name = "Nome")]
        [Required(ErrorMessage = "Este campo {0} é obrigatorio")]
        [StringLength(100, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Nome { get; set; }

        [Display(Name = "Descrição")]
        [Required(ErrorMessage = "Este campo {0} é obrigatorio")]
        [StringLength(1000, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Descricao { get; set; }

        public Fornecedor Fornecedor { get; set; }
        public Stock Stock { get; set; }
        public Requisicao Requisicao { get; set; }
    }
}
