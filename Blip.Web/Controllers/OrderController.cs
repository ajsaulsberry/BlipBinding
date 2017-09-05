using System;
using System.Net;
using System.Web.Mvc;
using Blip.Data.Orders;
using Blip.Entities.Orders.ViewModels;

namespace BlipProjects.Controllers
{
    public class OrderController : Controller
    {
        // GET: Order
        public ActionResult Index(string customerid)
        {
            if(!String.IsNullOrWhiteSpace(customerid))
            {
                if (Guid.TryParse(customerid, out Guid customerId))
                {
                    var repo = new OrdersRepository();
                    var model = repo.GetCustomerOrdersDisplay(customerId);
                    return View(model);
                }
            }
            return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(CustomerOrdersListViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (model.Orders != null)
                {
                    var repo = new OrdersRepository();
                    repo.SaveOrders(model.Orders);
                }
                return View(model);
            }
            return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        }
    }
}