using Microsoft.AspNetCore.Mvc;
using MyApplication.Entidades;
using Techsoft.MyApplication.Aplicacion.Servicios;

namespace Techsoft.MyApplication.Api.Controllers
{

    [Controller]
    [Route("api/clientes")]
    public class CilentesController : ControllerBase
    {

        private readonly ClienteService _clienteService;

        public CilentesController(ClienteService clienteService)
        {
            _clienteService = clienteService;
        }

        [HttpGet]
        public ActionResult<List<Cliente>> Get()
        {

            var result = _clienteService.ConsultarTodos();

            return Ok(result);
        }
    }
}
