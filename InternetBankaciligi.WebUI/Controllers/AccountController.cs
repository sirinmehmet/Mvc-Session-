using InternetBankaciligi.DataAccess.Contexts;
using InternetBankaciligi.Entities.Concrete;
using InternetBankaciligi.Entities.Dtos.Accounts;
using System;
using System.Linq;
using System.Web.Caching;
using System.Web.Mvc;

namespace InternetBankaciligi.WebUI.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginRequestDto dto)
        {
            if (dto is null)
                return View();

            if (!ModelState.IsValid)
                return View();

            using (var context = new InternetBankaciligiDbContext())
            {
                var currentUser = context.User.AsNoTracking().Where(x => x.IsActive == true && x.MailAddress == dto.MailAddress.Trim()).FirstOrDefault();

                if (currentUser == null)
                    return View();

                if (currentUser.Password != dto.Password)
                    return View();

                Session["UserId"] = currentUser.Id;
                Session["UserFirstName"] = currentUser.FirstName;
                Session["UserLastName"] = currentUser.LastName;
                Session["UserMailAddress"] = currentUser.MailAddress;
                Session["UserUsername"] = currentUser.Username;

                return RedirectToAction("Index", "Home");
            }
        }

        public ActionResult Logout()
        {
            Response.AddHeader("Cache-Control", "no-cache, no-store,must-revalidate");
            Response.AddHeader("Pragma", "no-cache");
            Response.AddHeader("Expires", "0");
            Session.Abandon();

            Session.Clear();
            Response.Cookies.Clear();
            Session.RemoveAll();

             return RedirectToAction("Login", "Account");
        }
    }
}