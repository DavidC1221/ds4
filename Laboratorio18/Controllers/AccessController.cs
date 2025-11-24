
using System;
using System.Web.Mvc;

namespace Laboratorio18.Controllers
{
    public class AccessController : Controller
    {
        // GET: Access
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Enter(string user, string password)
        {
            try
            {
                // Aquí normalmente se validaría contra base de datos
                return Content("1");
            }
            catch (Exception ex)
            {
                return Content("Ocurrio un error :( " + ex.Message);
            }
        }
    }
}
