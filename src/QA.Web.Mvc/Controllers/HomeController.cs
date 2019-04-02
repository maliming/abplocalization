using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using Abp.UI;
using QA.Controllers;

namespace QA.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : QAControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }


        public string Test()
        {
            return "test";
        }

    }
}
