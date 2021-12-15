using System;

namespace ApiCadastroSimples
{
    class Program
    {
        static SerieRepositorio repositorio = new SerieRepositorio();   
        
        static void Main(string[] args)
        {
            string opcaoUsuario = "" ;
            

            do
            {
              opcaoUsuario = ObterOpcaoUsuario();

                switch(opcaoUsuario)
                {
                    case "1":
                    ListarSeries();
                    break;

                    case "2":
                    InserirSerie();
                    break;

                    case "3":
                    AtualizarSerie();
                    break;

                    case "4":
                    ExcluirSerie();
                    break;

                    case "5":
                    VisualizarSerie();
                    break;

                    case "C":
                    Console.Clear();
                    break;

                    default:
                    throw new ArgumentOutOfRangeException();
                }

            } while(opcaoUsuario != "X");       
        }
        private static void InserirSerie()
        {
            var novaSerie = PreencherDadosSerie();
            repositorio.Inserir(novaSerie);
        }

        private static void ListarSeries()
        {
            System.Console.WriteLine("--- Listar séries ---");
            var lista = repositorio.Lista();

            if(lista.Count == 0)
            {
                System.Console.WriteLine("Nenhuma série cadastrada!");
                return;
            }

            foreach(var serie in lista)
            {
                var excluido = serie.retornaExclusao();               
                System.Console.WriteLine("#ID {0} - {1} {2}", serie.RetornaId(), serie.RetornarTitulo(), (excluido ? "*Excluído*" : ""));
            }
        }

        private static void AtualizarSerie()
        {
           System.Console.Write("Informe o ID da série a ser alterada: "); 
           int indiceSerie = int.Parse(Console.ReadLine());

           foreach(int i in Enum.GetValues(typeof(Genero)))
           {
               Console.WriteLine($"{Enum.GetName(typeof(Genero), i)} - {i}");
           }

           Console.Write("Digite o gênero entre as opções acima: ");
           int entradaGenero = int.Parse(Console.ReadLine());

           Console.Write("Título da série: ");
           string tituloEntrada = Console.ReadLine();

           Console.Write("Ano de lançamento: ");
           int anoEntrada = int.Parse(Console.ReadLine());

           Console.Write("Descrição: ");
           string descricaoEntrada = Console.ReadLine();

           Serie atualizarSerie = new Serie(id: indiceSerie,
                                            genero: (Genero) entradaGenero,
                                            titulo: tituloEntrada,
                                            ano: anoEntrada,
                                            descricao: descricaoEntrada);

            repositorio.Atualizar(indiceSerie, atualizarSerie);
        }

        private static void VisualizarSerie()
        {
            Console.Write("Informe o #ID da série a ser detalhada: ");
            int idSerie = int.Parse(Console.ReadLine());           

            var serie = repositorio.RetornaPorId(idSerie);
            System.Console.WriteLine();
            System.Console.WriteLine($"----- {serie.RetornarTitulo()} -----");
            System.Console.WriteLine(serie);
        }

        private static void ExcluirSerie()
        {
            System.Console.Write("Informe o ID da série: ");
            int idSerie = int.Parse(Console.ReadLine());

            repositorio.Excluir(idSerie);
        }

        private static string ObterOpcaoUsuario()
        {
            System.Console.WriteLine();
            System.Console.WriteLine("Informe a opção desejada: ");
            System.Console.WriteLine("1 - Listar séries");
            System.Console.WriteLine("2 - Inserir nova série");
            System.Console.WriteLine("3 - Atualizar série");
            System.Console.WriteLine("4 - Excluir série");
            System.Console.WriteLine("5 - Visualizar série");
            System.Console.WriteLine("C - Limpar Tela");
            System.Console.WriteLine("X - Sair");
            System.Console.WriteLine();

            string opcaoUsuario = Console.ReadLine().ToUpper();
            return opcaoUsuario;
        }
    
        private static Serie PreencherDadosSerie()
        {
            System.Console.WriteLine("--- Inserir nova série ---");

            foreach(int i in Enum.GetValues(typeof(Genero)))
            {
                System.Console.WriteLine($"{Enum.GetName(typeof(Genero), i)} - {i}");
            }

            System.Console.Write("Selecione o gênero dentre as opções acima: ");
            int generoEntrada = int.Parse(Console.ReadLine());

            System.Console.Write("Título da série: ");
            string tituloEntrada = Console.ReadLine();

            System.Console.Write("Ano de lançamento: ");
            int anoEntrada = int.Parse(Console.ReadLine());

            System.Console.Write("Descrição: ");
            string descricaoEntrada = Console.ReadLine();

            Serie novaSerie = new Serie(repositorio.ProximoId(),
                                        genero:(Genero) generoEntrada, 
                                        tituloEntrada, 
                                        descricaoEntrada, 
                                        anoEntrada);

            return novaSerie;
        }
    }
}
