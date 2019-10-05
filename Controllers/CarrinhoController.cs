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
    public class CarrinhoController : ControllerBase
    {
        public static List<Carrinho> carrinhos = new List<Carrinho>();
 
        //GET carrinho
        [HttpGet]
        public IEnumerable<Carrinho> GetAll()
        {
            List<Carrinho> carrinhos = Program.getCarrinhos();
            return carrinhos;
        }

        // add book to cart.
        //PUT api/carrinho/1
        [HttpPut("{id}")]
        public  IActionResult PutLivroCarrinho(int id, Livro livro)
        {
            List<Carrinho> carrinhos = Program.getCarrinhos();
            foreach(Carrinho c in carrinhos)
            {
                if (c.IdCarrinho == id)
                {
                    c.Livros.Add(livro);
      
                    return NoContent();            
                }
            }
             return BadRequest();
        }

        //remove book from carrinho
        // DELETE api/carrinho/1/1
        [HttpDelete("{carrinhoId}/{bookId}")]
        public IActionResult Delete(int carrinhoId,int bookId)
        {   
            List<Carrinho> carrinhos = Program.getCarrinhos();
            foreach (Carrinho c in carrinhos)
            {
                if(c.IdCarrinho == carrinhoId)
                {
                    foreach (Livro l in c.Livros)
                    {
                        if (l.Id == bookId)
                        {
                           c.Livros.Remove(l);
                           return NoContent();
                        }
                    }
                }

            }
            return NotFound();

        }






    }

}