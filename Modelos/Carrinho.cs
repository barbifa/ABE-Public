
using System;
using System.Collections.Generic;
using LivrariaApi.Modelos;
using System.Collections.Generic;

namespace LivrariaApi.Modelos
{
    public class Carrinho
    {
       public long IdCarrinho { get; set; }
       public long IdUsuario { get; set; }

       public List<Livro> Livros {get;set;}
      
         
    }
}