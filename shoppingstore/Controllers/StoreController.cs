using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using shoppingstore.Models;
using shoppingstore.Controllers;


namespace shoppingstore.Controllers
{
    public class StoreController : Controller
    {
        ShoppingStoreEntities storeDB = new ShoppingStoreEntities();
        // GET: Store
        public ActionResult Index()
        {
            var category = new List<Category>
            {
                new Category { Name = "Electronics"},
                new Category { Name ="Furniture"},
                new Category { Name = "Accessories"}
            };
            return View(category);
        }

        [ChildActionOnly]
        public  ActionResult CategoryMenu()
        {
            var categories = storeDB.Categories.ToList();

            return PartialView(categories);
        }


        public ActionResult Browse(string category)
        {

            //Aqui, cambie "Single" por "SingleOrDefault"
            var categoryModel = storeDB.Categories.Include("Items").Single(c=>c.Name==category);
            return View(categoryModel);
        }

        public ActionResult Details(int id)
        {
            //El id a encontrar tenia un .ToString()
            //Se lo quite porque me daba error cuando entraba a /store, luego a Electronics, y luego al articulo que estaba ahi
            var Item = storeDB.Items.Find(id);
            return View(Item);
        } 
    }
}