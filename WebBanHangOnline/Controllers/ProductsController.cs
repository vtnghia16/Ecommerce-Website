using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBanHangOnline.Models;
using WebBanHangOnline.Models.EF;

namespace WebBanHangOnline.Controllers
{
    public class ProductsController : Controller
    {
        // Lấy dbContext từ models  
        private ApplicationDbContext db = new ApplicationDbContext();


        public ActionResult Index(int? id)
        {
            var items = db.Products.ToList();
            if(id != null)
            {
                items = items.Where(x => x.Id == id).ToList();
            }
            return View(items);
        }

        public ActionResult Partial_ItemsByCateId()
        {
            var items = db.Products.Where(x => x.IsHome && x.IsActive).Take(12).ToList();
            return PartialView(items);
        }

        ////public ActionResult Partial_ProductSales()
        ////{
        ////    var items = db.Products.Where(x => x.IsSale && x.IsActive).Take(12).ToList();
        ////    return PartialView(items);
        ////}
    }
}