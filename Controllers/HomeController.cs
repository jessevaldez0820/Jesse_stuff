using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Valdez_Jesse_HW2.Models;

namespace Valdez_Jesse_HW2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CheckoutWalkup()
        {
            return View();
        }

        public IActionResult WalkupTotals(WalkupOrder walkupOrder)
        {
            TryValidateModel(walkupOrder);

            if (ModelState.IsValid == false) //something is wrong
            {
                return View("CheckoutWalkup", walkupOrder);//send user back to inputs page
            }

            //if code gets this far, everything is okay
            walkupOrder.CustomerType = CustomerTypes.Walkup;
            //calculate pay
            walkupOrder.CalculateTotals();

            //send user to results page
            return View("Totals", walkupOrder);
        }
        public IActionResult CheckoutWholesale()
        {
            return View();
        }
        public IActionResult WholesaleTotals(WholesaleOrder wholesaleOrder)
        {
            TryValidateModel(wholesaleOrder);

            if (ModelState.IsValid == false) //something is wrong
            {
                return View("CheckoutWholesale", wholesaleOrder);//send user back to inputs page
            }

            //if code gets this far, everything is okay
            wholesaleOrder.CustomerType = CustomerTypes.Wholesale;

            //calculate pay
            wholesaleOrder.CalculateTotals();

            //send user to results page
            return View("Totals", wholesaleOrder);
        }
    }
}