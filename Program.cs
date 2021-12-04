using System;
using System.Linq;
using Agenda.db;

namespace Agenda
{
    class Program
    {
        static void Main(string[] args)
        {
            bool sair = false;
            while (!sair)
            {
                string opcao = SelecionaOpcaoEmMenu();

                Console.WriteLine($"Opção selecionada: {opcao}\n");

                switch (opcao)
                {
                    case "L":
                        ListarTodosContatos();
                        break;

                    case "T":
                        Top5Contatos();
                        break;

                    case "C":
                        ConsultarContatosPorCodigo();
                        break;

                    case "N":
                        ConsultarContatosPorNome();
                        break;

                    case "I":
                        IncluirContato();
                        break;

                    case "S":
                        Console.WriteLine("- Sair");
                        sair = true;
                        break;

                    default:
                        Console.WriteLine($"Opção não reconhecida.");
                        break;
                }

                Console.Write("\nPressione uma tecla para continuar...");
                Console.ReadKey();
            }
        }

        static string SelecionaOpcaoEmMenu()
        {
            Console.Clear();
            Console.WriteLine("-- Agenda --\n");
            Console.WriteLine("[L]istar todos os contatos");
            Console.WriteLine("[T]op 5 contatos");
            Console.WriteLine("Consultar contatos por [C]ódigo");
            Console.WriteLine("Consultar contatos por [N]ome");
            Console.WriteLine("[I]ncluir contato");
            Console.WriteLine("[S]air");
            Console.Write("\nDigite a sua opção: ");

            string entrada = Console.ReadLine().ToUpper().Trim();
            return entrada.Length < 2 ? entrada : entrada.Substring(0, 1);
        }

        static void ListarTodosContatos()
        {
            Console.WriteLine("- Listar todos os contatos:");

            using(var agenda = new agendaContext())
            {
                int qtdDeContatos = agenda.Contatos.Count();  //Vai contar qtois registros eu tenho
                if (qtdDeContatos == 0)
                {
                     Console.WriteLine("Não há nenhum cadastro");
                     return;
                }
                Console.WriteLine($"{qtdDeContatos} contato(s) cadastrado(s)");
               foreach(var contato in agenda.Contatos)
               {
                   Console.WriteLine($"{contato.Id}: {contato.Nome}, {contato.Fone}, {contato.Estrelas} estrelas.");
               }
            }
        }

        static void Top5Contatos()
        {
            Console.WriteLine("- Top 5 contatos:");

            // Continue daqui
        }

        static void ConsultarContatosPorCodigo()
        {
            Console.WriteLine("- Consultar contatos por Código:");

            // Continue daqui
        }

        static void ConsultarContatosPorNome()
        {
            Console.WriteLine("- Consultar contatos por Nome:");

            // Continue daqui
        }

        static void IncluirContato()
        {
            Console.WriteLine("- Incluir contato:");

            // Continue daqui
        }
    }
}
