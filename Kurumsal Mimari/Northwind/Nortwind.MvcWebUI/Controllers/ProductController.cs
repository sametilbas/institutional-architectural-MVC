using Northwind.Bll.Concrete;
using Northwind.Dal.Concrete.EntityFramework;
using Northwind.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Nortwind.MvcWebUI.Controllers
{
    public class ProductController : Controller
    {
        ProductManager _productManager = new ProductManager(new EfProductDal());
        // GET: Product
        public ActionResult Index()
        {
            var product = _productManager.GetAll();
            return View(product);
        }
    }
}