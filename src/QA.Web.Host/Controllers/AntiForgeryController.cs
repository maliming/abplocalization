using Microsoft.AspNetCore.Antiforgery;
using QA.Controllers;

namespace QA.Web.Host.Controllers
{
    public class AntiForgeryController : QAControllerBase
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
