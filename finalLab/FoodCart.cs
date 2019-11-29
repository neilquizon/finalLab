using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace finalLab
{
    class FoodCartContext : DbContext
    {
        public DbSet<FoodCart> FoodCarts { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer("Data Source =LAPTOP-AS0EL1F8\\SQLEXPRESS; Initial Catalog = FoodCartApp; Integrated Security=true;");
    }

    class FoodCart
    {

        [Key]
        public string key { get; set; }

        public string status { get; set; }

        public string description { get; set; }
        public string geo_localarea { get; set; }
        public float longitude { get; set; }
        public float latitude { get; set; }
        public string location { get; set; }
        public string vendor_type { get; set; }
        public string business_name { get; set; }

    }
}
