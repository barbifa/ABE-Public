
using System;
using System.Collections.Generic;
using LivrariaApi.Modelos;
using System.Collections.Generic;

namespace LivrariaApi.Modelos

{
    public class Livro
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<String> comentarios { get; set; }
        public string Genero {get; set;}

        public string Autor {get;set;}

    }
}