using GMarket.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GMarket.Data
{

    public class SeedDb
    {
        private readonly DataContext context;
        private Random random;

        public SeedDb(DataContext context)
        {
            this.context = context;
            this.random = new Random();
        }

        public async Task SeedAsync()
        {
            await this.context.Database.EnsureCreatedAsync();

            if (!this.context.Countries.Any())
            {
                this.AddCountry("Honduras");
                this.AddCountry("Estados Unidos");
                this.AddCountry("España");
                await this.context.SaveChangesAsync();
            }
        }

        private void AddCountry(string name)
        {
            this.context.Countries.Add(new Country
            {
                Name = name,               
            });
        }
    }

}
