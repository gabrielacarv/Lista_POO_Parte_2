using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_9
{
    internal class Menu
    {
        public void menus() 
        {
            Biblioteca biblioteca = new Biblioteca();           

            while (true)
            {
                Console.WriteLine("======================================= MENU =======================================");
                Console.WriteLine("1 - Adicionar livro");
                Console.WriteLine("2 - Remover livro");
                Console.WriteLine("3 - Listar livros");
                Console.WriteLine("4 - Listar livros em ordem alfabética de título");
                Console.WriteLine("5 - Listar livros por idioma");
                Console.WriteLine("6 - Listar autores com livros publicados em idiomas diferentes do idioma nativo");
                Console.WriteLine("7 - Listar livros por autor");
                Console.WriteLine("0 - Sair");
                Console.Write("Digite o número correspondente com a opção que deseja:");
                int opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("============== ADICIONAR LIVRO ==============");
                        Console.Write("Digite o ISBN:");
                        string isbn = Console.ReadLine();
                        Console.Write("Digite o nome do livro:");
                        string nomeLivro = Console.ReadLine();
                        Console.Write("Digite o idioma do livro:");
                        string idioma = Console.ReadLine();
                        Console.Write("Digite a edição do livro:");
                        int edicao = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Digite a data de lançamento do livro (dd/mm/aaaa):");
                        DateTime dataLancamento = Convert.ToDateTime(Console.ReadLine());
                        Console.Write("Digite o nome do autor:");
                        string nomeAutor = Console.ReadLine();
                        Console.Write("Digite o país de origem do autor:");
                        string paisOrigem = Console.ReadLine();
                        Console.Write("Digite a data de nascimento do autor (dd/mm/aaaa):");
                        DateTime dataNascimento = Convert.ToDateTime(Console.ReadLine());
                        Console.Write("Digite o idioma nativo do autor:");
                        string idiomaNativo = Console.ReadLine();

                        Autor autor = new Autor()
                        {
                            Nome = nomeAutor,
                            PaisOrigem = paisOrigem,
                            DataNascimento = dataNascimento,
                            IdiomaNativo = idiomaNativo
                        };

                        Livro livro = new Livro()
                        {
                            ISBN = isbn,
                            NomeLivro = nomeLivro,
                            AutorLivro = autor,
                            Idioma = idioma,
                            Edicao = edicao,
                            DataLancamento = dataLancamento
                        };

                        biblioteca.AdicionarLivro(livro);

                        Console.WriteLine("Livro adicionado com sucesso.");
                        Console.WriteLine();
                        Console.WriteLine();
                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("============ REMOVER LIVRO ============");
                        Console.WriteLine("Digite o ISBN do livro a ser removido:");
                        string isbnRemover = Console.ReadLine();
                        biblioteca.RemoverLivro(isbnRemover);
                        Console.WriteLine();
                        Console.WriteLine();
                        break;

                    case 3:
                        Console.Clear();
                        biblioteca.ListarLivros();
                        Console.WriteLine();
                        Console.WriteLine();
                        break;

                    case 4:
                        Console.Clear();
                        biblioteca.ListarLivrosOrdemAlfabetica();
                        Console.WriteLine();
                        Console.WriteLine();
                        break;

                    case 5:
                        Console.Clear();
                        Console.WriteLine("Digite o idioma:");
                        string idiomaListar = Console.ReadLine();
                        biblioteca.ListarLivroPorIdioma(idiomaListar);
                        Console.WriteLine();
                        Console.WriteLine();
                        break;

                    case 6:
                        Console.Clear();
                        biblioteca.ListarAutorOutroIdioma();
                        Console.WriteLine();
                        Console.WriteLine();
                        break;

                    case 7:
                        Console.Clear();
                        Console.WriteLine("Digite o autor:");
                        string escritor = Console.ReadLine();
                        biblioteca.ListarLivroPorIdioma(escritor);
                        Console.WriteLine();
                        Console.WriteLine();
                        break;

                    case 0:
                        Console.Clear();
                        Console.WriteLine("Sair...");
                            Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Opção inválida.");
                        Console.WriteLine();
                        Console.WriteLine();
                        break;
                }
            }

            Console.ReadLine();
        }

    }
            
}
