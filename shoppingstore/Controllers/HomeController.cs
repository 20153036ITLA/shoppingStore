using shoppingstore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace shoppingstore.Controllers
{
    public class HomeController : Controller
    {

        ShoppingStoreEntities storeDB = new ShoppingStoreEntities();

        private List<Item> GetTopSellingItems(int count)
        {
            return storeDB.Items.OrderByDescending(i => i.OrderDatails).Take(count).ToList();
        }
        public ActionResult Index()
        {
            var items = GetTopSellingItems(5);

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}