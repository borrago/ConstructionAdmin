using System.ComponentModel.DataAnnotations;

namespace ConstructionAdmin.Models
{
    public class Stock : Entity
    {
        [Display(Name = "Data")]
        public DateTime Date_Stock { get; set; }

        [Display(Name = "Quantidade")]
        public int Quantidade { get; set; }

        [Display(Name = "Item")]
        public Guid ItemId { get; set; }
        public Item Item { get; set; }
    }
}
