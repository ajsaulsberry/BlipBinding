using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Blip.Entities.Orders;

namespace Blip.Entities.Items
{
    public class Item
    {
        public Item()
        {
            Orders = new HashSet<Order>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid ItemID { get; set; }

        [Required]
        [MaxLength(128)]
        public String Description { get; set; }

        public int ReorderQuantity { get; set; }

        public decimal MSRP { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
