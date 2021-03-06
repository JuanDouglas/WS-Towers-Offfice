﻿using ShowProducts.API.Controllers;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace WSTowersOffice.Api.Controllers
{
    public class HomeController : Controller
    {
        public async Task<ActionResult> Index()
        {
            var loginResult = await LoginController.ValidLoginAsync();
            if (!loginResult.IsValid)
            {
                return RedirectToActionPermanent("Authentication", "Logins");
            }
            return View();
        }
        public async Task<ActionResult> About()
        {
            var loginResult = await LoginController.ValidLoginAsync();
            if (!loginResult.IsValid)
            {
                return RedirectToActionPermanent("Authentication", "Logins");
            }
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