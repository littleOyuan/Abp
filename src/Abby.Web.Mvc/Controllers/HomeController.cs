using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using Abby.Controllers;

namespace Abby.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : AbbyControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
