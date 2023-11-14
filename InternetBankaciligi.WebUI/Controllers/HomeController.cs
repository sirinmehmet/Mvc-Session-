using InternetBankaciligi.Entities.Dtos.Users;
using System.Web.Mvc;

namespace InternetBankaciligi.WebUI.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            var currentUserId = Session["UserId"];

            if (currentUserId == null)
            {
                return RedirectToAction("Login", "Account");
            }

            return View(new UserResponseDto
            {
                FirstName = Session["UserFirstName"].ToString(),
                LastName = Session["UserLastName"].ToString(),
                Username = Session["UserUsername"].ToString(),
                MailAddress = Session["UserMailAddress"].ToString()
            });
        }
    }
}