using santisart_app.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace santisart_app.Controllers
{
    public class studentController : Controller
    {
        // GET: student
<<<<<<< HEAD
        santisartEntities2 db = new santisartEntities2();
=======
        backupServerEntities1 db = new backupServerEntities1();
>>>>>>> 81fd92b2750a4cd9bd85dec9ed1efdf1a5981156
        public ActionResult Index()
        {

            return View(db.Students.ToList());
        }
    }
}