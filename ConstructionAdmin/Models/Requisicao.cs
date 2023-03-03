using System.ComponentModel.DataAnnotations;

namespace ConstructionAdmin.Models
{
    public class Requisicao : Entity
    {
        [Display(Name = "Data")]
        public DateTime Data_Requesicao { get; set; }

        [Display(Name = "Estado")]
        public string Estado_Requesicao { get; set; }

        [Display(Name = "Justificação")]
        public string Justificacao { get; set; }

        [Display(Name = "Observação")]
        public string Observacao { get; set; }

        [Display(Name = "Item")]
        public Guid ItemId { get; set; }
        public Item Item { get; set; }
    }
}
