using System;
using System.Collections.Generic;
using System.Linq;
using Blip.Entities.Orders.ViewModels;

namespace Blip.Data.Orders
{
    public class OrdersRepository
    {
        public CustomerOrdersListViewModel GetCustomerOrdersDisplay(Guid customerid)
        {
            if (customerid != null && customerid != Guid.Empty)
            {
                using (var context = new ApplicationDbContext())
                {
                    var customerRepo = new CustomersRepository();
                    var customer = customerRepo.GetCustomer(customerid);
                    if (customer != null)
                    {
                        var customerOrdersListVm = new CustomerOrdersListViewModel()
                        {
                            CustomerID = customer.CustomerID,
                            CustomerName = customer.CustomerName,
                            CountryNameEnglish = context.Countries.Find(customer.CountryIso3).CountryNameEnglish,
                            RegionNameEnglish = context.Regions.Find(customer.RegionCode).RegionNameEnglish
                        };

                        List<OrderDisplayViewModel> orderList = context.Orders.AsNoTracking()
                            .Where(x => x.CustomerID == customerid)
                            .OrderBy(x => x.OrderDate)
                            .Select( x => 
                            new OrderDisplayViewModel
                            {
                                CustomerID = x.CustomerID,
                                OrderID = x.OrderID,
                                OrderDate = x.OrderDate,
                                Description = x.Description
                            }).ToList();
                        customerOrdersListVm.Orders = orderList;
                        return customerOrdersListVm;
                    }
                }
            }
            return null;
        }

        public void SaveOrders(List<OrderDisplayViewModel> orders)
        {
            if (orders != null)
            {
                using (var context = new ApplicationDbContext())
                {
                    foreach (var order in orders)
                    {
                        var record = context.Orders.Find(order.OrderID);
                        if (record != null)
                        {
                            record.Description = order.Description;
                        }
                    }
                    context.SaveChanges();
                }
            }
        }
    }
}
