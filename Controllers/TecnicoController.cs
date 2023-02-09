using Microsoft.AspNetCore.Mvc;
using OSManager.Data;

namespace OSManager.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TecnicoController : ControllerBase
    {
        private OSContext _oscontext;
        public TecnicoController(OSContext sContext)
        {
            _oscontext = sContext;
        }
    }
}
