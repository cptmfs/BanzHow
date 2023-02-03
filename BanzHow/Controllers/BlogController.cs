using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BanzHow.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        public ActionResult Index()
        {
            //veritabanından bütün blog bilgilerini al ve View üzerine gönder.
            //kendisine gelen blog bilgilerini dinamik içerik üreten View yapısı bunu statik HTML'e çevirir.
            //bloglar
            return View();
        }
        public ActionResult Details()
        {
            return View();
        }
    }
}