using System.Web.Http;
using Laboratorio19.Models.WS;

namespace Laboratorio19.Controllers
{
    public class AccessController : ApiController
    {
        [HttpGet]
        public Reply HelloWorld()
        {
            var oR = new Reply();
            oR.result = 1;
            oR.data = null;
            oR.message = "Hi Hello World en API!";
            return oR;
        }
    }
}
