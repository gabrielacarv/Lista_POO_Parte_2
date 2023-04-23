using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Exercício_9
{
    internal class Biblioteca
    {
        private List<Livro> ListaDeLivros;

        public Biblioteca()
        {
            ListaDeLivros = new List<Livro>();
        }

        public void AdicionarLivro(Livro livro)
        {
            ListaDeLivros.Add(livro);
        }

        public void RemoverLivro(string ISBN)
        {
            int index = ListaDeLivros.FindIndex(l => l.ISBN == ISBN);
            if (index >= 0)
            {
                ListaDeLivros.RemoveAt(index);
                Console.WriteLine("Livro removido com sucesso!");
            }
            else
            {
                Console.WriteLine("Livro não encontrado!");
            }
        }

        public void ListarLivros()
        {
            Console.WriteLine("============ LISTA DE LIVRO ============");
            foreach (Livro livro in ListaDeLivros)
            {
                Console.WriteLine("ISBN: {0}, Nome: {1}, Autor: {2}, Idioma: {3}, Edição: {4}, Data de Lançamento: {5}",
                    livro.ISBN, livro.NomeLivro, livro.AutorLivro.Nome, livro.Idioma, livro.Edicao, livro.DataLancamento.ToShortDateString());
            }
        }

        public void ListarLivrosOrdemAlfabetica()
        {
            Console.WriteLine("============ LISTA DE LIVRO ORDEM ALFABÉTICA ============");
            ListaDeLivros.Sort((x, y) => x.NomeLivro.CompareTo(y.NomeLivro));
            ListarLivros();
        }

        public void ListarLivroPorIdioma(string idioma)
        {
            Console.WriteLine("============ LISTA DE LIVRO EM {0} ============", idioma);
            foreach (Livro livro in ListaDeLivros)
            {
                if (livro.Idioma == idioma)
                {
                    Console.WriteLine("ISBN: {0}, Nome: {1}, Autor: {2}, Idioma: {3}, Edição: {4}, Data de Lançamento: {5}",
                        livro.ISBN, livro.NomeLivro, livro.AutorLivro.Nome, livro.Idioma, livro.Edicao, livro.DataLancamento.ToShortDateString());
                }
            }
        }

        public void ListarAutorOutroIdioma()
        {
            Console.WriteLine("========== AUTORES COM LIVROS EM IDIOMAS DIFERENTES DO IDIOMA NATIVO ==========");

            Dictionary<Autor, int> autoresLivrosOutroIdioma = new Dictionary<Autor, int>();

            foreach (Livro livro in ListaDeLivros)
            {
                if (livro.AutorLivro.IdiomaNativo != livro.Idioma)
                {
                    if (autoresLivrosOutroIdioma.ContainsKey(livro.AutorLivro))
                    {
                        autoresLivrosOutroIdioma[livro.AutorLivro]++;
                    }
                    else
                    {
                        autoresLivrosOutroIdioma.Add(livro.AutorLivro, 1);
                    }
                }
            }

            foreach (KeyValuePair<Autor, int> autorLivros in autoresLivrosOutroIdioma)
            {
                Console.WriteLine("- Autor: {0}, Livros publicados em outros idiomas: {1}", autorLivros.Key.Nome, autorLivros.Value);
            }
        }

        public void ListarLivroPorNomeAutor(string autor)
        {
            Console.WriteLine("============ LISTA DE LIVRO POR {0} ============", autor);
            foreach (Livro livro in ListaDeLivros)
            {
                if (livro.AutorLivro.Nome == autor)
                {
                    Console.WriteLine("ISBN: {0}, Nome: {1}, Autor: {2}, Idioma: {3}, Edição: {4}, Data de Lançamento: {5}",
                        livro.ISBN, livro.NomeLivro, livro.AutorLivro.Nome, livro.Idioma, livro.Edicao, livro.DataLancamento.ToShortDateString());
                }
            }
        }

    }
}
