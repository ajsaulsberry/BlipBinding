using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Blip.Entities.Items;

namespace Blip.Entities.Orders
{
    public class OrderItem
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public virtual Guid ItemID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public virtual Guid OrderID { get; set; }

        public decimal Price { get; set; }

        public short Quantity { get; set; }

        public virtual Order Order { get; set; }

        public virtual Item Item { get; set; }
    }
}
