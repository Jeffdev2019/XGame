using Domain.Arguments.Jogador;
using Domain.Interfaces.Repositories;
using Domain.Services;
using System;

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


            AutenticarJogadorRequest request = new AutenticarJogadorRequest();
            Console.WriteLine("Criei Instancia do meu objeto de request.");


            var response = serviceJogador.AutenticarJogador(request);

            Console.ReadKey();
        }
    }
}
