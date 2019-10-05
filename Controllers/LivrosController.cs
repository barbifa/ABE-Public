using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LivrariaApi.Modelos;
using System.Runtime.Serialization.Json;
using System.Threading.Tasks;

namespace LivrariaApi.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class LivrosController : ControllerBase
    {
        public static List<Livro> livros = new List<Livro>();
        bool isCreated = false;
        // GET /api/livros/
        [HttpGet]
        public IEnumerable<Livro> GetAll()
        {
            List<Livro> books = Program.getData();
            return books;

        }
        // GET api/livros/1
        [HttpGet("{id}")]
        public ActionResult<Livro> Get(int id)
        {
            List<Livro> books = Program.getData();
            foreach(Livro l in books)
            {
                if (l.Id == id)
                {
                    return l;
                }
            }

            return NotFound();
        }

        //Pesquisa de livros por critérios diversos.
        // api/livros/g1
        [HttpGet("{genero}/genero")]
        public ActionResult<List<Livro>> GetGenero(string genero)
        {
            List<Livro> books = Program.getData();
            List<Livro> booksFound = new List<Livro>();
            foreach(Livro l in books)
            {
                if (string.Equals(l.Genero,genero))
                {
                    booksFound.Add(l);
                }
            }
            return booksFound;
        }

        //autor
        [HttpGet("{autor}/autor")]
        public ActionResult<List<Livro>> GetAutor(string autor)
        {
            List<Livro> books = Program.getData();
            List<Livro> booksFound = new List<Livro>();
            foreach(Livro l in books)
            {
                if (string.Equals(l.Autor,autor))
                {
                    booksFound.Add(l);
                }
            }
            return booksFound;
        }

        //cadastrar Livros
        // POST api/livros
        [HttpPost]
        public IActionResult PostAdicionarLivro (Livro livro)
        {
            List<Livro> books = Program.getData();
            books.Add(livro);

            return NoContent();    
        }


        // adicionar comentario em livro ja existente
        // PUT api/livros/5
        [HttpPut("{id}")]
        public ActionResult PutCometarioLivro(int id, [FromBody] string comentario)
        {
             List<Livro> books = Program.getData();
            foreach(Livro l in books)
            {
                if (l.Id == id)
                {
                    l.comentarios.Add(comentario);
                    return NoContent();
                    
                }
            }
             return BadRequest();

        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {

        }






    }

}