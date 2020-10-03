using CSSMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CSSMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Test = "Controller'dan View'e Mesaj";
            int a = 1;
            int b = 3;
            int sub = a + b;
            ViewBag.Toplam = sub;

            List<Product> productList = new List<Product>();

           // productList = veritabanından gelen veriler;

            Product product1 = new Product();
            Product product2 = new Product();

            product1.Id = 1;
            product1.Name = "Şemsiye";
            product1.Price = "20 TL";
            product1.Quantity = "4.jpg";
            
            product2.Id = 2;
            product2.Name = "Top";
            product2.Price = "30 TL";
            product2.Quantity = "5.jpg";

            productList.Add(product1);
            productList.Add(product2);

            return View(productList);
        }


    }
}