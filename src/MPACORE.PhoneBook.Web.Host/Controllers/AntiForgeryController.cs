using Microsoft.AspNetCore.Antiforgery;
using MPACORE.PhoneBook.Controllers;

namespace MPACORE.PhoneBook.Web.Host.Controllers
{
    public class AntiForgeryController : PhoneBookControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
