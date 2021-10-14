using System;
using DIOSeries.Enums;
using DIOSeries.Classes;

namespace DIOSeries
{
    class Program
    {
        static SerieRepositorio serieRepositorio = new SerieRepositorio();
        static void Main(string[] args)
        {

            string opcaoUsuario = ObterOpcaoUsuario();

            while(opcaoUsuario != "X")
            {
                switch(opcaoUsuario)
                {
                    case "1":
                        ListarSeries();
                        break;
                    case "2":
                        InserirSerie();
                        break;
                    case "3":
                        break;
                    case "4":
                        break;
                    case "5":
                        break;
                    case "C":
                        Console.Clear();
                        break;
                    case "X":
                        break;
                }

                opcaoUsuario = ObterOpcaoUsuario();
            }
            
        }

        private static void InserirSerie()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" *** INSERIR SÉRIES *** ");
            Console.ResetColor();

            int novoId = serieRepositorio.ProximoId();

            Console.WriteLine("GÊNEROS:");

            foreach(int i in Enum.GetValues(typeof(Genero)))
            {
                Console.WriteLine($"{i} - {Enum.GetName(typeof(Genero), i)}");
            }

            Console.Write("INFORME O GÊNERO ........: ");
            int genero = int.Parse(Console.ReadLine());

            Console.Write("INFORME O TÍTULO ........: ");
            string titulo = Console.ReadLine();

            Console.Write("INFORME UMA DESCRIÇÃO ...: ");
            string descricao = Console.ReadLine();

            Console.Write("INFORME O ANO DE INÍCIO .: ");
            int ano = int.Parse(Console.ReadLine());

            Serie serie = new Serie(novoId, (Genero)genero, titulo, descricao, ano);

            serieRepositorio.Insere(serie);

        }

        private static void ListarSeries()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" *** LISTAR SÉRIES *** ");
            Console.ResetColor();

            var lista = serieRepositorio.Lista();

            if (VerificarLista())
                return;

            foreach(var serie in lista)
            {
                Console.WriteLine($"#ID: {serie.RetornaId()} - Título: {serie.RetornaTitulo()}");
            }
        }

        private static bool VerificarLista()
        {
            var sr = serieRepositorio.Lista();

            if (sr.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Nenhuma série cadastrada.\n");
                Console.ResetColor();
                return true;
            }

            return false;
        }

        private static string ObterOpcaoUsuario()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine();
            Console.WriteLine("DIO Séries a seu dispor!!");
            Console.WriteLine("1 - Listar séries");
            Console.WriteLine("2 - Inserir nova série");
            Console.WriteLine("3 - Atualizar série");
            Console.WriteLine("4 - Excluir série");
            Console.WriteLine("5 - Visualizar série");
            Console.WriteLine("C - Limpar Tela");
            Console.WriteLine("X - Sair");
            Console.Write("Informe a opção desejada: ");
            Console.ResetColor();

            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();

            return opcaoUsuario;
        }
    }
}
