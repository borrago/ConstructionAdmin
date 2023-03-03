using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace ConstructionAdmin.Models
{
    public class Fornecedor : Entity
    {
        [Display(Name = "Ativo")]
        public bool Ativo { get; set; }

        [Display(Name = "Nome")]
        [Required(ErrorMessage = "Este campo {0} é obrigatorio")]
        [StringLength(100, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Nome { get; set; }

        [Display(Name = "Descrição")]
        [Required(ErrorMessage = "Este campo {0} é obrigatorio")]
        [StringLength(1000, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Descricao { get; set; }

        [Display(Name = "Endereço")]
        [Required(ErrorMessage = "Este campo {0} é obrigatorio")]
        [StringLength(200, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Endereco { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "Este campo {0} é obrigatorio")]
        [StringLength(100, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Email { get; set; }

        [Display(Name = "Contato")]
        [Required(ErrorMessage = "Este campo {0} é obrigatorio")]
        [StringLength(100, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string Contato { get; set; }

        [Display(Name = "CNPJ")]
        [Required(ErrorMessage = "Este campo {0} é obrigatorio")]
        [StringLength(15, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 15)]
        public string CNPJ { get; set; }

        [Display(Name = "CPF")]
        [Required(ErrorMessage = "Este campo {0} é obrigatorio")]
        [StringLength(11, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 11)]
        public string CPF { get; set; }

        [Display(Name = "Nome do Contato")]
        [Required(ErrorMessage = "Este campo {0} é obrigatorio")]
        [StringLength(100, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        public string NomeContato { get; set; }

        public IEnumerable<Item> Items { get; set; }
    }
}
