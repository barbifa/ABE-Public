using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LivrariaApi.Modelos;
using System.Runtime.Serialization.Json;

namespace LivrariaApi.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class PedidosController : ControllerBase
    {

        [HttpPost]
        public IActionResult PostAdicionarLivro (Pedido pedido)
        {
            List<Pedido> pedidos = Program.getPedidos();
            pedidos.Add(pedido);

            return NoContent();    
        }

        //acompanhar o status das entregas
        // GET /api/pedidos/
        [HttpGet]
        public IEnumerable<Pedido> GetAll()
        {
            List<Pedido> pedidos = Program.getPedidos();
            return pedidos;

        }
        // GET api/pedidos/1
        [HttpGet("{id}")]
        public ActionResult<Pedido> Get(int id)
        {
            List<Pedido> pedidos = Program.getPedidos();
            foreach(Pedido l in pedidos)
            {
                if (l.IdPedido == id)
                {
                    return l;
                }
            }

            return NotFound();
        }

    }

}