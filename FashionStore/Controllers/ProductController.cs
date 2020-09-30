using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FashionStore.Models;

namespace FashionStore.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            OnlineStoreContext onlineStoreContext = new OnlineStoreContext();
            List<ProductDetail> products = onlineStoreContext.Products.ToList();
            return View(products);
        }
    }
}