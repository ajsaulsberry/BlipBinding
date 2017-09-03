using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Blip.Entities.Customers;
using Blip.Entities.Orders;

namespace Blip.Entities.Orders.ViewModels
{
    public class OrderDisplayViewModel
    {
        public Guid CustomerID { get; set; }

        [Display(Name = "Order Number")]
        public Guid OrderID { get; set; }

        [Display(Name = "Order Date")]
        public DateTime OrderDate { get; set; }

        [Display(Name = "PO / Description")]
        public string Description { get; set; }
    }
}
