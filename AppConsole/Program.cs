using Domain.Arguments.Jogador;
using Domain.Interfaces.Repositories;
using Domain.Services;
using System;
using System.Linq;

namespace AppConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //IRepositoryJogador Repository;
            Console.WriteLine("Iniciando...");

            ServiceJogador serviceJogador = new ServiceJogador();

            Console.WriteLine("Criei Instancia do Serviço.0");


            AutenticarJogadorRequest request = new AutenticarJogadorRequest("xpto@xmail.com", "1234567");
            Console.WriteLine("Criei Instancia do meu objeto de request.");


            
            var response = serviceJogador.AutenticarJogador(request);

            Console.WriteLine("Serviço é válido - > " + serviceJogador.IsValid());

            serviceJogador.Notifications.ToList().ForEach(x =>
            {
                Console.WriteLine(x.Message);
            });

            Console.ReadKey();
        }
    }
}
