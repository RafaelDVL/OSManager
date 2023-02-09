using Microsoft.AspNetCore.Mvc;
using OSManager.Data;
using OSManager.Model;

namespace OSManager.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClienteController: ControllerBase
    {
        private OSContext _oscontext; 

        public ClienteController(OSContext sContext)
        {
            this._oscontext = sContext;
        }

        
    }
}
