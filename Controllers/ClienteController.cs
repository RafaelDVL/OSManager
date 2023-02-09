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

        [HttpPost]
        public IActionResult CreateCliente([FromBody] Cliente cliente)
        {
            try
            {
                _oscontext.Clientes.Add(cliente);
                _oscontext.SaveChanges();
                return CreatedAtAction(nameof(GetByID), new { id = cliente.Id }, cliente);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                return BadRequest();
            }
            
        }

        [HttpGet]
         public IEnumerable<Cliente> GetClientes()
        {
            return _oscontext.Clientes;
        }

        [HttpGet("{id}")]
        public IActionResult GetByID(int id)
        {
            Cliente cliente = _oscontext.Clientes.FirstOrDefault(cliente => cliente.Id == id);
            return Ok(cliente);
        }

        
    }
}
