using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Shop.Controllers
{
    public class ReviewsController : BaseController
    {
        // GET: Reviews
        public ActionResult Index([Bind(Prefix ="Id")]int productId)
        {
            var product = _db.Products.Find(productId);
            if (product != null)
            {
                return View(product);
            }
                return HttpNotFound();
        }
    }
}