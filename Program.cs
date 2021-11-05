using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using MongoDB.Bson;
using MongoDB.Driver;
using Curso_Mongodb_Net.Model;

namespace Curso_Mongodb_Net
{
    class Program
    {
        #region Programa Linear 
        // static void Main(string[] args)
        // {
        //     // Console.WriteLine("Hello World!");

        //  MainSync(args);
        //  Console.WriteLine("Testando comando");
        //  Console.ReadLine();
        // }
        // static void MainSync(string[] args){
        //     Console.WriteLine("Congelando o sistema por 10 segundos");
        //     System.Threading.Thread.Sleep(10000);
        //     Console.WriteLine("Sistema descongelou .............");
        // }
        #endregion

        #region Programa Assincrono
        //  static void Main(string[] args)
        // {
        // Task T = MainSync(args);
        //  Console.WriteLine("Testando comando");
        //  Console.ReadLine();
        // }
        // static async Task MainSync(string[] args){
        //     Console.WriteLine("Congelando o sistema por 10 segundos");
        //     await Task.Delay(10000);
        //     Console.WriteLine("Sistema descongelou .............");
        // }
        #endregion

        #region Programa Manipulando Arquivos Usando BsonDocument
        //  static void Main(string[] args)
        // {
        // Task T = MainSync(args);
        //  Console.WriteLine("Testando comando");
        //  Console.ReadLine();
        // }
        // static async Task MainSync(string[] args){


        //     var doc = new BsonDocument{
        //         {"Titulo","Guerra dos Tronos"}
        //     };
        //     doc.Add("Autor","George R R Martin");
        //     doc.Add("Ano",1999);
        //     doc.Add("Paginas",856);

        //     var assuntoArray = new BsonArray();
        //     assuntoArray.Add("Fantasia");
        //     assuntoArray.Add("Ação");

        //     doc.Add("Assunto", assuntoArray);

        //     Console.WriteLine(doc);

        // }
        #endregion

        #region Programa Grando no MongoDb

        // static void Main(string[] args)
        // {
        //     Task T = MainSync(args);
        //     Console.WriteLine("Testando comando");
        //     Console.ReadLine();
        // }
        // static async Task MainSync(string[] args)
        // {


        //     var doc = new BsonDocument{
        //         {"Titulo","Guerra dos Tronos"}
        //     };
        //     doc.Add("Autor", "George R R Martin");
        //     doc.Add("Ano", 1999);
        //     doc.Add("Paginas", 856);

        //     var assuntoArray = new BsonArray();
        //     assuntoArray.Add("Fantasia");
        //     assuntoArray.Add("Ação");

        //     doc.Add("Assunto", assuntoArray);

        //     Console.WriteLine(doc);

        //     //Conectando ao Mongodb
        //     string stringConexao = "mongodb://localhost:27017";
        //     IMongoClient cliente = new MongoClient(stringConexao);

        //     //Acessando o banco do mongodb
        //     IMongoDatabase bancoDados = cliente.GetDatabase("Biblioteca");

        //     //Acesso a coleção do banco
        //     IMongoCollection<BsonDocument> colecao = bancoDados.GetCollection<BsonDocument>("Livros");

        //     //Salvando o documento no banco
        //     await colecao.InsertOneAsync(doc);

        //     Console.WriteLine("Documento Salvo com sucesso");
        // }
        #endregion

        #region Programa Grando no MongoDb com class
        // static void Main(string[] args)
        // {
        //     Task T = MainSync(args);
        //     Console.WriteLine("Testando comando");
        //     Console.ReadLine();
        // }
        // static async Task MainSync(string[] args)
        // {

        //     Livro livro = new Livro();
        //     livro.Titulo = "Sob a redoma";
        //     livro.Autor = "Stepahn King";
        //     livro.Ano = 2012;
        //     livro.Paginas = 679;

        //     List<string> listaAssunto = new List<string>();
        //     listaAssunto.Add("Ficção Cientifica");
        //     listaAssunto.Add("Terror");
        //     listaAssunto.Add("Ação");

        //     livro.Assunto = listaAssunto;

        //     //Conectando ao Mongodb
        //     string stringConexao = "mongodb://localhost:27017";
        //     IMongoClient cliente = new MongoClient(stringConexao);

        //     //Acessando o banco do mongodb
        //     IMongoDatabase bancoDados = cliente.GetDatabase("Biblioteca");

        //     //Acesso a coleção do banco
        //     IMongoCollection<Livro> colecao = bancoDados.GetCollection<Livro>("Livros");

        //     //Salvando o documento no banco
        //     await colecao.InsertOneAsync(livro);

        //     Console.WriteLine("Documento Salvo com sucesso");

        // }
        #endregion


        #region Programa Otimizando conexao com Banco MongoDb
        static void Main(string[] args)
        {
            Task T = MainSync(args);
            Console.WriteLine("Testando comando");
            Console.ReadLine();
        }
        static async Task MainSync(string[] args)
        {

            Livro livro = new Livro();
            livro.Titulo = "Star Wars Legends";
            livro.Autor = "Timothy Zahn";
            livro.Ano = 2010;
            livro.Paginas = 245;

            List<string> listaAssunto = new List<string>();
            listaAssunto.Add("Ficção Cientifica");
            listaAssunto.Add("Ação");

            livro.Assunto = listaAssunto;

            //Utilizando a class de conexão
            var conexaoBiblioteca = new conectandoMongoDB();

            //Salvando o documento no banco
            await conexaoBiblioteca.Livros.InsertOneAsync(livro);

            Console.WriteLine("Documento Salvo com sucesso");

        }
        #endregion

    }
}
