using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AlVigha.Models;

namespace AlVigha.Controllers.Admin
{
    public class AdminCustomersController : Controller
    {
        AlVighaEntities DB = new AlVighaEntities();
        // GET: AdminCustomers
        public ActionResult Index()
        {
            List<Account> customersList = DB.Accounts.Where(x => x.account_type == 2).ToList();
            return View("~/Views/Admin/AdminCustomers.cshtml", customersList);
            //}
        }
    }
}