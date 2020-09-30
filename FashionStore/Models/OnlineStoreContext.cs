using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FashionStore.Models
{
    public class OnlineStoreContext : DbContext
    {
        public DbSet<ProductDetail> Products { get; set; }
        public DbSet<CategoryDetail> Categories { get; set; }
        public DbSet<ShippingDetail> ShippingDetails { get; set; }
    }
}