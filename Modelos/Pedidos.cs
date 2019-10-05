
using System;
using System.Collections.Generic;
using LivrariaApi.Modelos;
using System.Collections.Generic;

namespace LivrariaApi.Modelos

{
    public class Pedido
    {
        public int IdPedido { get; set; }

        public Carrinho Carrinho { get; set; }

        public string Status  { get; set; }

    }
}