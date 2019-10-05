using System;

using System.Collections.Generic;

using System.IO;

using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using LivrariaApi.Modelos;


namespace LivrariaApi
{
    public class Program
    {
        public static List<Livro> livros = new List<Livro>();
        public static List<Carrinho> carrinhos  = new List<Carrinho>();

        public static List<Pedido> pedidos = new List<Pedido>();
        public static void Main(string[] args)
        {
            createData();
            createDataCarrinho();
            createPedidos();
            CreateWebHostBuilder(args).Build().Run();

        }



        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
              .UseStartup<Startup>();



        public static void createPedidos()
        {
            createData();
             Carrinho carrinho1 = new Carrinho();
             carrinho1.IdCarrinho = 1;
             carrinho1.IdUsuario = 1;
             carrinho1.Livros =   livros;

            Pedido pedido1 = new Pedido();
            pedido1.IdPedido = 1;
            pedido1.Status = "Em andamento";
            pedido1.Carrinho = carrinho1;


            Carrinho carrinho2 = new Carrinho();
             carrinho2.IdCarrinho = 2;
             carrinho2.IdUsuario = 2;
             carrinho1.Livros =   livros;

            Pedido pedido2 = new Pedido();
            pedido1.IdPedido = 2;
            pedido1.Status = "Entregue";
            pedido1.Carrinho = carrinho2;

            pedidos.Add(pedido1);
            pedidos.Add(pedido2);
        }

        public  static List<Pedido> getPedidos()
        {
            return pedidos;
        }

        public static void createDataCarrinho()
        {
            Carrinho carrinho1 = new Carrinho();
             carrinho1.IdCarrinho = 1;
             carrinho1.IdUsuario = 1;
             carrinho1.Livros =   livros;

            Carrinho carrinho2 = new Carrinho();
             carrinho2.IdCarrinho = 2;
             carrinho2.IdUsuario = 2;
             carrinho2.Livros =   livros;

             carrinhos.Add(carrinho1);
             carrinhos.Add(carrinho2);
             
        }

        public  static List<Carrinho> getCarrinhos()
        {
            return carrinhos;
        }
        public static void createData()
        {
            Livro livro1 = new Livro();
            livro1.Id = 1;
            livro1.Name = "livro 1";
            livro1.comentarios = new List<string>(){
                 "c1",   
                 "c2"
            };
            livro1.Autor = "a1";
            livro1.Genero = "g1";

            Livro livro2 = new Livro();
            livro2.Id = 2;
            livro2.Name = "livro 2";
            livro2.comentarios = new List<string>(){
                 "c1",   
                 "c2"

            };   
            livro2.Autor = "a2";
            livro2.Genero = "g1";      

            livros.Add(livro1);
            livros.Add(livro2);

        }

        public static List<Livro> getData()

        {
            return livros;
        }

            

    }

}