using DomainTeste.Entidades;
using Newtonsoft.Json;
using System;
using System.Linq;

namespace ConsoleTeste
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Testes
            //new Produto().Listar().Where(p => p.Valor > 4).ToList().ForEach(item => {
            //    Console.WriteLine(item.Nome);
            //    Console.WriteLine(item.Valor);
            //        });

            //var produto = new Produto();

            //var produtos = produto.Listar().Where(p => p.Valor > 4);

            //foreach (var item in produtos)
            //{
            //    Console.WriteLine(item.Nome);
            //}

            //int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //foreach (var numero in numeros.Where(n => n > 4))
            //{
            //    Console.WriteLine(numero);
            //}
            #endregion

            // Aula 4.

            var produtos = new Produto().Listar();

            var nomes = produtos
                .Where(p => p.Nome.StartsWith("M") || p.Nome.EndsWith("i"))
                .Select(p => new { Name = p.Nome, Value = p.Valor })
                .ToList();

            nomes.ForEach(item => 
            { 
                Console.WriteLine(JsonConvert.SerializeObject(item));
                Console.WriteLine("\n");
            });

            Console.ReadKey();
        }
    }
}
