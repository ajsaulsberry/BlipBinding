namespace Blip.Data.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Blip.Entities.Customers;
    using Blip.Entities.Geographies;
    using Blip.Entities.Items;
    using Blip.Entities.Orders;

    internal sealed class Configuration : DbMigrationsConfiguration<ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            var countries = new List<Country>
            {
                new Country {
                    Iso3 = "USA",
                    CountryNameEnglish = "United States of America"
                },
                new Country
                {
                    Iso3 = "CAN",
                    CountryNameEnglish = "Canada"
                },
                new Country
                {
                    Iso3 = "FRA",
                    CountryNameEnglish = "France"
                }
            };
            countries.ForEach(s => context.Countries.AddOrUpdate(p => p.Iso3, s));
            context.SaveChanges();

            var regions = new List<Region>
            {
                new Region
                {
                    Iso3 = "USA",
                    RegionCode = "AL",
                    RegionNameEnglish = "Alabama"
                },
                new Region
                {
                    Iso3 = "USA",
                    RegionCode = "AK",
                    RegionNameEnglish = "Alaska"
                },
                new Region
                {
                    Iso3 = "USA",
                    RegionCode = "AZ",
                    RegionNameEnglish = "Arizona"
                },
                new Region
                {
                    Iso3 = "USA",
                    RegionCode = "AR",
                    RegionNameEnglish = "Arkansas"
                },
                new Region
                {
                    Iso3 = "USA",
                    RegionCode = "CA",
                    RegionNameEnglish = "California"
                },
                new Region
                {
                    Iso3 = "USA",
                    RegionCode = "CO",
                    RegionNameEnglish = "Colorado"
                },
                new Region
                {
                    Iso3 = "USA",
                    RegionCode = "CT",
                    RegionNameEnglish = "Connecticut"
                },
                new Region
                {
                    Iso3 = "USA",
                    RegionCode = "DC",
                    RegionNameEnglish = "District of Columbia"
                },
                new Region
                {
                    Iso3 = "USA",
                    RegionCode = "DE",
                    RegionNameEnglish = "Delaware"
                },
                new Region
                {
                    Iso3 = "USA",
                    RegionCode = "FL",
                    RegionNameEnglish = "Florida"
                },
                new Region
                {
                    Iso3 = "USA",
                    RegionCode = "GA",
                    RegionNameEnglish = "Georgia"
                },
                new Region
                {
                    Iso3 = "USA",
                    RegionCode = "HI",
                    RegionNameEnglish = "Hawaii"
                },
                new Region
                {
                    Iso3 = "USA",
                    RegionCode = "IA",
                    RegionNameEnglish = "Iowa"
                },
                new Region
                {
                    Iso3 = "USA",
                    RegionCode = "ID",
                    RegionNameEnglish = "Idaho"
                },
                new Region
                {
                    Iso3 = "USA",
                    RegionCode = "IL",
                    RegionNameEnglish = "Illinois"
                },
                new Region
                {
                    Iso3 = "USA",
                    RegionCode = "IN",
                    RegionNameEnglish = "Indiana"
                },
                new Region
                {
                    Iso3 = "USA",
                    RegionCode = "KS",
                    RegionNameEnglish = "Kansas"
                },
                new Region
                {
                    Iso3 = "USA",
                    RegionCode = "KY",
                    RegionNameEnglish = "Kentucky"
                },
                new Region
                {
                    Iso3 = "USA",
                    RegionCode = "LA",
                    RegionNameEnglish = "Louisiana"
                },
                new Region
                {
                    Iso3 = "USA",
                    RegionCode = "MD",
                    RegionNameEnglish = "Maryland"
                },
                new Region
                {
                    Iso3 = "USA",
                    RegionCode = "ME",
                    RegionNameEnglish = "Maine"
                },
                new Region
                {
                    Iso3 = "USA",
                    RegionCode = "MA",
                    RegionNameEnglish = "Massachsetts"
                },
                new Region
                {
                    Iso3 = "USA",
                    RegionCode = "MI",
                    RegionNameEnglish = "Michigan"
                },
                new Region
                {
                    Iso3 = "USA",
                    RegionCode = "MN",
                    RegionNameEnglish = "Minnesota"
                },
                new Region
                {
                    Iso3 = "USA",
                    RegionCode = "MS",
                    RegionNameEnglish = "Mississippi"
                },
                new Region
                {
                    Iso3 = "USA",
                    RegionCode = "MO",
                    RegionNameEnglish = "Missouri"
                },
                new Region
                {
                    Iso3 = "USA",
                    RegionCode = "MT",
                    RegionNameEnglish = "Montana"
                },
                new Region
                {
                    Iso3 = "USA",
                    RegionCode = "NE",
                    RegionNameEnglish = "Nebraska"
                },
                new Region
                {
                    Iso3 = "USA",
                    RegionCode = "NV",
                    RegionNameEnglish = "Nevada"
                },
                new Region
                {
                    Iso3 = "USA",
                    RegionCode = "NH",
                    RegionNameEnglish = "New Hampshire"
                },
                new Region
                {
                    Iso3 = "USA",
                    RegionCode = "NJ",
                    RegionNameEnglish = "New Jersey"
                },
                new Region
                {
                    Iso3 = "USA",
                    RegionCode = "NM",
                    RegionNameEnglish = "New Mexico"
                },
                new Region
                {
                    Iso3 = "USA",
                    RegionCode = "NY",
                    RegionNameEnglish = "New York"
                },
                new Region
                {
                    Iso3 = "USA",
                    RegionCode = "NC",
                    RegionNameEnglish = "North Carolina"
                },
                new Region
                {
                    Iso3 = "USA",
                    RegionCode = "ND",
                    RegionNameEnglish = "North Dakota"
                },
                new Region
                {
                    Iso3 = "USA",
                    RegionCode = "OH",
                    RegionNameEnglish = "Ohio"
                },
                new Region
                {
                    Iso3 = "USA",
                    RegionCode = "OK",
                    RegionNameEnglish = "Oklahoma"
                },
                new Region
                {
                    Iso3 = "USA",
                    RegionCode = "OR",
                    RegionNameEnglish = "Oregon"
                },
                new Region
                {
                    Iso3 = "USA",
                    RegionCode = "PA",
                    RegionNameEnglish = "Pennsylvania"
                },
                new Region
                {
                    Iso3 = "USA",
                    RegionCode = "RI",
                    RegionNameEnglish = "Rhode Island"
                },
                new Region
                {
                    Iso3 = "USA",
                    RegionCode = "SC",
                    RegionNameEnglish = "South Carolina"
                },
                new Region
                {
                    Iso3 = "USA",
                    RegionCode = "SD",
                    RegionNameEnglish = "South Dakota"
                },
                new Region
                {
                    Iso3 = "USA",
                    RegionCode = "TN",
                    RegionNameEnglish = "Tennessee"
                },
                new Region
                {
                    Iso3 = "USA",
                    RegionCode = "TX",
                    RegionNameEnglish = "Texas"
                },
                new Region
                {
                    Iso3 = "USA",
                    RegionCode = "UT",
                    RegionNameEnglish = "Utah"
                },
                new Region
                {
                    Iso3 = "USA",
                    RegionCode = "VT",
                    RegionNameEnglish = "Vermont"
                },
                new Region
                {
                    Iso3 = "USA",
                    RegionCode = "VA",
                    RegionNameEnglish = "Virginia"
                },
                new Region
                {
                    Iso3 = "USA",
                    RegionCode = "WA",
                    RegionNameEnglish = "Washington"
                },
                new Region
                {
                    Iso3 = "USA",
                    RegionCode = "WV",
                    RegionNameEnglish = "West Virginia"
                },
                new Region
                {
                    Iso3 = "USA",
                    RegionCode = "WI",
                    RegionNameEnglish = "Wisconsin"
                },
                new Region
                {
                    Iso3 = "USA",
                    RegionCode = "WY",
                    RegionNameEnglish = "Wyoming"
                },
                new Region
                {
                    Iso3 = "USA",
                    RegionCode = "AS",
                    RegionNameEnglish = "American Samoa"
                },
                new Region
                {
                    Iso3 = "USA",
                    RegionCode = "FM",
                    RegionNameEnglish = "Federated States of Micronesia"
                },
                new Region
                {
                    Iso3 = "USA",
                    RegionCode = "GU",
                    RegionNameEnglish = "Guam"
                },
                new Region
                {
                    Iso3 = "USA",
                    RegionCode = "MH",
                    RegionNameEnglish = "Marshall Islands"
                },
                new Region
                {
                    Iso3 = "USA",
                    RegionCode = "MP",
                    RegionNameEnglish = "Northern Mariana Islands"
                },
                new Region
                {
                    Iso3 = "USA",
                    RegionCode = "PR",
                    RegionNameEnglish = "Puerto Rico"
                },
                new Region
                {
                    Iso3 = "USA",
                    RegionCode = "VI",
                    RegionNameEnglish = "US Virgin Islands"
                },
                new Region
                {
                    Iso3 = "CAN",
                    RegionCode = "AB",
                    RegionNameEnglish = "Alberta"
                },
                new Region
                {
                    Iso3 = "CAN",
                    RegionCode = "BC",
                    RegionNameEnglish = "British Columbia"
                },
                new Region
                {
                    Iso3 = "CAN",
                    RegionCode = "MB",
                    RegionNameEnglish = "Manitoba"
                },
                new Region
                {
                    Iso3 = "CAN",
                    RegionCode = "NB",
                    RegionNameEnglish = "New Brunswick"
                },
                new Region
                {
                    Iso3 = "CAN",
                    RegionCode = "NF",
                    RegionNameEnglish = "Newfoundland"
                },
                new Region
                {
                    Iso3 = "CAN",
                    RegionCode = "NT",
                    RegionNameEnglish = "Northwest Territories"
                },
                new Region
                {
                    Iso3 = "CAN",
                    RegionCode = "NS",
                    RegionNameEnglish = "Nova Scotia"
                },
                new Region
                {
                    Iso3 = "CAN",
                    RegionCode = "NU",
                    RegionNameEnglish = "Nunavut"
                },
                new Region
                {
                    Iso3 = "CAN",
                    RegionCode = "ON",
                    RegionNameEnglish = "Ontario"
                },
                new Region
                {
                    Iso3 = "CAN",
                    RegionCode = "PE",
                    RegionNameEnglish = "Prince Edward Island"
                },
                new Region
                {
                    Iso3 = "CAN",
                    RegionCode = "QC",
                    RegionNameEnglish = "Québec"
                },
                new Region
                {
                    Iso3 = "CAN",
                    RegionCode = "SK",
                    RegionNameEnglish = "Saskatchewan"
                },
                new Region
                {
                    Iso3 = "CAN",
                    RegionCode = "YT",
                    RegionNameEnglish = "Yukon"
                }
            };
            regions.ForEach(s => context.Regions.AddOrUpdate(p => p.RegionCode, s));
            context.SaveChanges();

            var customers = new List<Customer>
            {
                new Customer
                {
                    CustomerID = Guid.NewGuid(),
                    CustomerName = "Cogswell Cogs",
                    CountryIso3 = "USA",
                    RegionCode = "CA"
                },
                new Customer
                {
                    CustomerID = Guid.NewGuid(),
                    CustomerName = "Spacely Space Sprockets",
                    CountryIso3 = "USA",
                    RegionCode = "TX"
                },
                new Customer
                {
                    CustomerID = Guid.NewGuid(),
                    CustomerName = "Amagamated Flange",
                    CountryIso3 = "CAN",
                    RegionCode = "QC"
                }
            };
            customers.ForEach(s => context.Customers.AddOrUpdate(p => p.CustomerID, s));
            context.SaveChanges();

            var items = new List<Item>
            {
                new Item
                {
                    ItemID = Guid.NewGuid(),
                    Description = "Laser Drill Press",
                    ReorderQuantity = 4,
                    MSRP = 1103.99M
                },
                new Item
                {
                    ItemID = Guid.NewGuid(),
                    Description = "Quantum Impeller",
                    ReorderQuantity = 12,
                    MSRP = 3.13M
                },
                new Item
                {
                    ItemID = Guid.NewGuid(),
                    Description = "Flux Capacitor",
                    ReorderQuantity = 10,
                    MSRP = 6.17M
                },
                new Item
                {
                    ItemID = Guid.NewGuid(),
                    Description = "Dilithium Crystal",
                    ReorderQuantity = 1000,
                    MSRP = 42
                },
                new Item
                {
                    ItemID = Guid.NewGuid(),
                    Description = "Aluminum Tube",
                    ReorderQuantity = 100,
                    MSRP = 2.12M
                }
            };
            items.ForEach(s => context.Items.AddOrUpdate(p => p.ItemID, s));
            context.SaveChanges();

            var orders = new List<Order>
            {
                new Order
                {
                    OrderID = Guid.NewGuid(),
                    CustomerID = context.Customers.Where(x => x.CustomerName == "Cogswell Cogs").Single().CustomerID,
                    OrderDate = DateTime.Parse("2017-07-14"),
                    Description = "PO CC-17-042"
                },
                new Order
                {
                    OrderID = Guid.NewGuid(),
                    CustomerID = context.Customers.Where(x => x.CustomerName == "Cogswell Cogs").Single().CustomerID,
                    OrderDate = DateTime.Parse("2017-07-30"),
                    Description = "PO CC-17-091"
                },
                new Order
                {
                    OrderID = Guid.NewGuid(),
                    CustomerID = context.Customers.Where(x => x.CustomerName == "Spacely Space Sprockets").Single().CustomerID,
                    OrderDate = DateTime.Parse("2017-08-03"),
                    Description = "Spacely 2017-00110001"
                }
            };
            orders.ForEach(s => context.Orders.AddOrUpdate(p => p.OrderID, s));
            context.SaveChanges();

            var orderitems = new List<OrderItem>
            {
                new OrderItem
                {
                    OrderID = context.Orders.Where(x => x.Description == "PO CC-17-042").Single().OrderID,
                    ItemID = context.Items.Where(x => x.Description == "Laser Drill Press").Single().ItemID,
                    Price = context.Items.Where(x => x.Description == "Laser Drill Press").Single().MSRP,
                    Quantity = 3
                },
                new OrderItem
                {
                    OrderID = context.Orders.Where(x => x.Description == "PO CC-17-042").Single().OrderID,
                    ItemID = context.Items.Where(x => x.Description == "Aluminum Tube").Single().ItemID,
                    Price = context.Items.Where(x => x.Description == "Aluminum Tube").Single().MSRP,
                    Quantity = 21
                },
                new OrderItem
                {
                    OrderID = context.Orders.Where(x => x.Description == "PO CC-17-091").Single().OrderID,
                    ItemID = context.Items.Where(x => x.Description == "Aluminum Tube").Single().ItemID,
                    Price = context.Items.Where(x => x.Description == "Aluminum Tube").Single().MSRP,
                    Quantity = 4
                },
                new OrderItem
                {
                    OrderID = context.Orders.Where(x => x.Description == "PO CC-17-091").Single().OrderID,
                    ItemID = context.Items.Where(x => x.Description == "Flux Capacitor").Single().ItemID,
                    Price = context.Items.Where(x => x.Description == "Flux Capacitor").Single().MSRP,
                    Quantity = 21
                },
                new OrderItem
                {
                    OrderID = context.Orders.Where(x => x.Description == "PO CC-17-091").Single().OrderID,
                    ItemID = context.Items.Where(x => x.Description == "Quantum Impeller").Single().ItemID,
                    Price = context.Items.Where(x => x.Description == "Quantum Impeller").Single().MSRP,
                    Quantity = 1
                },
                new OrderItem
                {
                    OrderID = context.Orders.Where(x => x.Description == "Spacely 2017-00110001").Single().OrderID,
                    ItemID = context.Items.Where(x => x.Description == "Quantum Impeller").Single().ItemID,
                    Price = context.Items.Where(x => x.Description == "Quantum Impeller").Single().MSRP,
                    Quantity = 1
                },
                new OrderItem
                {
                    OrderID = context.Orders.Where(x => x.Description == "Spacely 2017-00110001").Single().OrderID,
                    ItemID = context.Items.Where(x => x.Description == "Flux Capacitor").Single().ItemID,
                    Price = context.Items.Where(x => x.Description == "Flux Capacitor").Single().MSRP,
                    Quantity = 1
                },
                new OrderItem
                {
                    OrderID = context.Orders.Where(x => x.Description == "Spacely 2017-00110001").Single().OrderID,
                    ItemID = context.Items.Where(x => x.Description == "Dilithium Crystal").Single().ItemID,
                    Price = context.Items.Where(x => x.Description == "Dilithium Crystal").Single().MSRP,
                    Quantity = 100
                }
            };
            orderitems.ForEach(s => context.OrderItems.AddOrUpdate(p => new { p.OrderID, p.ItemID }, s));
            context.SaveChanges();
        }
    }
}

