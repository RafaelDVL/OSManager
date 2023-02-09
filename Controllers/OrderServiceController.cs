using Microsoft.AspNetCore.Mvc;
using OSManager.Data;

namespace OSManager.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderServiceController : ControllerBase
    {
        private OSContext _oscontext;

        public OrderServiceController(OSContext sContext)
        {
            _oscontext = sContext;
        }
    }
}
