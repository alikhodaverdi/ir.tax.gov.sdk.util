using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ir.tax.gov.sdk.util.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CryptoUtilsController : ControllerBase
    {
        public static CryptoUtils cryptoUtils =new CryptoUtils();

        [HttpPost("/test")]
        public ActionResult<CryptoUtils> Test()
        {
            var testc =cryptoUtils.GetType();
            return Ok(testc);
        }


    }
}
