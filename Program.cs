using System.Linq;
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
        // static void Main(string[] args)
        // {
        //     Task T = MainSync(args);
        //     Console.WriteLine("Testando comando");
        //     Console.ReadLine();
        // }
        // static async Task MainSync(string[] args)
        // {

        //     Livro livro = new Livro();
        //     livro.Titulo = "Star Wars Legends";
        //     livro.Autor = "Timothy Zahn";
        //     livro.Ano = 2010;
        //     livro.Paginas = 245;

        //     List<string> listaAssunto = new List<string>();
        //     listaAssunto.Add("Ficção Cientifica");
        //     listaAssunto.Add("Ação");

        //     livro.Assunto = listaAssunto;

        //     //Utilizando a class de conexão
        //     var conexaoBiblioteca = new conectandoMongoDB();

        //     //Salvando o documento no banco
        //     await conexaoBiblioteca.Livros.InsertOneAsync(livro);

        //     Console.WriteLine("Documento Salvo com sucesso");

        // }
        #endregion

        #region Programa Class Livro Banco MongoDb
        //         static void Main(string[] args)
        //         {
        //             Task T = MainSync(args);
        //             Console.WriteLine("Testando comando");
        //             Console.ReadLine();
        //         }
        //         static async Task MainSync(string[] args)
        //         {

        //             Livro livro = new Livro();
        //             livro.Titulo = "Star Wars Legends";
        //             livro.Autor = "Timothy Zahn";
        //             livro.Ano = 2010;
        //             livro.Paginas = 245;

        //             List<string> listaAssunto = new List<string>();
        //             listaAssunto.Add("Ficção Cientifica");
        //             listaAssunto.Add("Ação");

        //             livro.Assunto = listaAssunto;

        //             //Utilizando a class de conexão
        //             var conexaoBiblioteca = new conectandoMongoDB();

        //             //Salvando o documento no banco
        //             await conexaoBiblioteca.Livros.InsertOneAsync(livro);

        //             Console.WriteLine("Documento Salvo com sucesso");

        //         }
        #endregion

        #region Programa Gravando em massa Banco MongoDb
        // static void Main(string[] args)
        // {
        //     Task T = MainSync(args);
        //     Console.WriteLine("Testando comando");
        //     Console.ReadLine();
        // }
        // static async Task MainSync(string[] args)
        // {



        //     //Utilizando a class de conexão
        //     var conexaoBiblioteca = new conectandoMongoDB();

        //     List<Livro> Livros = new List<Livro>();


        //     Livros.Add(ValoresLivro.incluiValoresLivros("Titulo do filme", "Alex Marafon", 1992, 29, "TI, dev, programador"));
        //     Livros.Add(ValoresLivro.incluiValoresLivros("Titulo", "Alex Marafon", 1992, 29, "TI, dev, programador"));
        //     Livros.Add(ValoresLivro.incluiValoresLivros("Titulo 2", "Alex Marafon", 1992, 29, "TI, dev, programador"));
        //     Livros.Add(ValoresLivro.incluiValoresLivros("Titulo 3", "Alex Marafon", 1992, 29, "TI, dev, programador"));
        //     Livros.Add(ValoresLivro.incluiValoresLivros("Titulo 4", "Alex Marafon", 1992, 29, "TI, dev, programador"));
        //     Livros.Add(ValoresLivro.incluiValoresLivros("Titulo 5 filme", "Alex Marafon", 1992, 29, "TI, dev, programador"));
        //     Livros.Add(ValoresLivro.incluiValoresLivros("Titulo do filme 6", "Alex Marafon", 1992, 29, "TI, dev, programador"));
        //     Livros.Add(ValoresLivro.incluiValoresLivros("Titulo do filme 7", "Alex Marafon", 1992, 29, "TI, dev, programador"));
        //     Livros.Add(ValoresLivro.incluiValoresLivros("Titulo do filme 8", "Alex Marafon", 1992, 29, "TI, dev, programador, full stack, fodao em lynq, c#,csharp, empreendedor"));


        //     await conexaoBiblioteca.Livros.InsertManyAsync(Livros);

        //     Console.WriteLine("Documento Salvo com sucesso");

        // }
        #endregion

        #region Programa Recuperando do Banco MongoDb
        // static void Main(string[] args)
        // {
        //     Task T = MainSync(args);
        //     Console.WriteLine("Testando comando");
        //     Console.ReadLine();
        // }
        // static async Task MainSync(string[] args)
        // {

        //     var conexaoBiblioteca = new conectandoMongoDB();

        //     Console.WriteLine("Imprimindo lista de Livros");

        //     var listaLivros = await conexaoBiblioteca.Livros.Find(new BsonDocument()).ToListAsync();

        //     foreach (var doc in listaLivros)
        //     {
        //         Console.WriteLine(doc.ToJson<Livro>());
        //     }

        //     Console.WriteLine("Fim da lista");

        // }
        #endregion

        #region Programa Recuperando "BsomDocument" com criterio do Banco MongoDb
        // static void Main(string[] args)
        // {
        //     Task T = MainSync(args);
        //     Console.WriteLine("Testando comando");
        //     Console.ReadLine();
        // }
        // static async Task MainSync(string[] args)
        // {

        //     var conexaoBiblioteca = new conectandoMongoDB();

        //     Console.WriteLine("Imprimindo lista de Livros");

        //     // var filtro = new BsonDocument{
        //     //     {"Assunto","c#"}
        //     // };
        //     var listaLivros = await conexaoBiblioteca.Livros.Find( new BsonDocument()).ToListAsync();

        //     foreach (var doc in listaLivros)
        //     {
        //         Console.WriteLine(doc.ToJson<Livro>());
        //     }

        //     Console.WriteLine("Fim da lista");

        // }
        #endregion


        #region Programa Recuperando a partir de uma class do Banco MongoDb
        static void Main(string[] args)
        {
            Task T = MainSync(args);
            Console.WriteLine("Testando comando");
            Console.ReadLine();
        }
        static async Task MainSync(string[] args)
        {

            var conexaoBiblioteca = new conectandoMongoDB();

            Console.WriteLine(" ");
            Console.WriteLine(" -------------------- Condição simples------------------------ ");
            Console.WriteLine(" ");

            var filtro = new BsonDocument{
                {"Assunto","c#"}
            };
            var listaLivros = await conexaoBiblioteca.Livros.Find(filtro).ToListAsync();

            foreach (var doc in listaLivros)
            {
                Console.WriteLine(doc.ToJson<Livro>());
            }

            Console.WriteLine(" ");
            Console.WriteLine(" ------------------- Utilizando recursos do Bsom (Eq = Igual)------------------------- ");
            Console.WriteLine(" ");


            var construtor = Builders<Livro>.Filter;
            var condicao = construtor.Eq(x => x.Titulo, "Titulo");
            var ClassLivros = await conexaoBiblioteca.Livros.Find(condicao).ToListAsync();

            foreach (var doc in ClassLivros)
            {
                Console.WriteLine(doc.ToJson<Livro>());
            }


            Console.WriteLine(" ");
            Console.WriteLine(" ------------------ Utilizando recursos do Bsom (Gte = Igual ou Maio com 2 condiçoes)-------------------------- ");
            Console.WriteLine(" ");



            var collection = Builders<Livro>.Filter;
            var filter = construtor.Gte(x => x.Ano, 1992) & construtor.Gte(x => x.Paginas, 29);
            var retorno = await conexaoBiblioteca.Livros.Find(filter).ToListAsync();

            foreach (var doc in retorno)
            {
                Console.WriteLine(doc.ToJson<Livro>());
            }

            Console.WriteLine(" ");
            Console.WriteLine(" ------------------ Recuperando a partir de uma sublista do mongoDb-------------------------- ");
            Console.WriteLine(" ");



            var col = Builders<Livro>.Filter;
            //AnyEq  propriedade que busca dentro de uma Array/Lista
            var fil = construtor.AnyEq(x => x.Assunto, "csharp");
            var ret = await conexaoBiblioteca.Livros.Find(fil).ToListAsync();

            foreach (var doc in ret)
            {
                Console.WriteLine(doc.ToJson<Livro>());
            }

            Console.WriteLine(" ");
            Console.WriteLine(" -------------------------------------------- ");
            Console.WriteLine(" ");
            Console.WriteLine("Fim da lista");

        }
        #endregion


    }
}
