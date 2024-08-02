using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace GerenciamentoLivros
{
    //Crie um teste unitário para o método AdicionarLivro que verifica se um livro é adicionado corretamente a uma lista de livros.
    public class GerenciamentoLivro
    {

        public static bool AdcionarLivro(Livro livro)
        {
            List<Livro> livros = new List<Livro>();

            livros.Add(livro);

            return livros.Count > 0;
        }

        public class Livro
        {
            public string Titulo { get; set; }
            public string Autor { get; set; }
        }
    }
}
