using System.Collections.Generic;
using System.Net.NetworkInformation;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Curso_Mongodb_Net.Model
{
    public class Livro
    {
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public int Ano { get; set; }
        public int Paginas { get; set; }
        public List<string> Assunto { get; set; }   


        public Livro incluiValoresLivros(string Titulo, string Autor, int Ano, int Paginas, string assuntos) {

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