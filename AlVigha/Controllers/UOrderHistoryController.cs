using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AlVigha.Models;

namespace AlVigha.Controllers
{
    public class UOrderHistoryController : Controller
    {
        AlVighaEntities DB = new AlVighaEntities();
        // GET: UOrderHistory
        public ActionResult Index()
        {
            var cur = Session["userID"];
            if (cur != null)
            {
                List<Order> ordersList = DB.Orders.Where(x => x.CustomerID == ((AlVigha.Models.Account)cur).account_ID).ToList();
                return View(ordersList);
            }
            else
            {
                return View();
            }
        }

        
            public ActionResult ViewItem(int orderID)
        {
            var cur = Session["userID"];
            if (cur != null)
            {
                //List<Order> ordersList = DB.Orders.Where(x => x.CustomerID == ((AlVigha.Models.Account)cur).account_ID).ToList();

                var orderHistory = from ol in DB.Orders
                                   join od in DB.Order_Details on ol.orderID equals od.orderID
                                   join cust in DB.Accounts on ol.CustomerID equals cust.account_ID
                                   join item in DB.Menus on od.itemID equals item.itemID
                                   where ol.orderID == orderID 
                                   select new ViewModel
                                   {
                                       order = ol,
                                       order_Details = od,
                                       customer = cust,
                                       menuItem = item
                                   };

                return View(orderHistory);
            }
            else
            {
                return RedirectToAction("Index", "Authentication");
            }
        }
    }
}