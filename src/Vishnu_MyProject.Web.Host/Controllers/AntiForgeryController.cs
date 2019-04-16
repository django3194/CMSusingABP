using Microsoft.AspNetCore.Antiforgery;
using Vishnu_MyProject.Controllers;

namespace Vishnu_MyProject.Web.Host.Controllers
{
    public class AntiForgeryController : Vishnu_MyProjectControllerBase
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
