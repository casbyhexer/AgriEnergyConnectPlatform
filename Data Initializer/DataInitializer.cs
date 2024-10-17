using System;
using System.Collections.Generic;
using System.Linq;
using AgriEnergyConnectPlatform.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace AgriEnergyConnectPlatform.Data
{
    public class DataInitializer : IDataInitializer
    {
        private readonly ApplicationDbContext DbContext;

        public DataInitializer(ApplicationDbContext DbContext)
        {
            this.DbContext = DbContext;
        }

        public void SeedData()
        {
            DbContext.Database.Migrate();

            if (!DbContext.Farmer.Any())
            {
                var farmers = new List<Farmers>
                {
                    new Farmers
                    {
                        Name = "John Doe",
                        Location = "Springfield",
                        Number = "1234567890",
                        Products = new List<Products>
                        {
                            new Products { Name = "Wheat", Price = 10.5m },
                            new Products { Name = "Corn", Price = 12.0m }
                        }
                    },
                    new Farmers
                    {
                        Name = "Jane Smith",
                        Location = "Shelbyville",
                        Number = "0987654321",
                        Products = new List<Products>
                        {
                            new Products { Name = "Apples", Price = 5.5m },
                            new Products { Name = "Oranges", Price = 7.0m }
                        }
                    }
                };

                DbContext.Farmer.AddRange(farmers);
                DbContext.SaveChanges();
            }
        }
    }
}
