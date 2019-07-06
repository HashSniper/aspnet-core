using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using MPACORE.PhoneBook.Controllers;

namespace MPACORE.PhoneBook.Web.Controllers
{
    [AbpMvcAuthorize]
    public class AboutController : PhoneBookControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
