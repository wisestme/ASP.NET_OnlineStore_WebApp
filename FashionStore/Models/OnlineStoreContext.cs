﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FashionStore.Models
{
    public class OnlineStoreContext : DbContext
    {
        public DbSet<ProductTbl> Products { get; set; }
    }
}