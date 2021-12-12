using System.Collections.Generic;
namespace Curso_Mongodb_Net.Model
{
    public class ValoresLivro
    {
        public static Livro incluiValoresLivros(string Titulo, string Autor, int Ano, int Paginas, string assuntos) {

            Livro Livro = new Livro();
            Livro.Titulo = Titulo;
            Livro.Autor = Autor;
            Livro.Ano = Ano;
            Livro.Paginas = Paginas;
            string[] vetAssunt = assuntos.Split(',');
            List<string> vetAssunto2 = new List<string>();
            for(int i =0; i <= vetAssunt.Length -1 ; i++){
                vetAssunto2.Add(vetAssunt[i].Trim());
            }
            Livro.Assunto = vetAssunto2;
            return Livro;
      }
        
        
    }
}