using System.Reflection.Metadata;
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
        // static void Main(string[] args)
        // {
        //     Task T = MainSync(args);
        //     Console.WriteLine("Testando comando");
        //     Console.ReadLine();
        // }
        // static async Task MainSync(string[] args)
        // {

        //     var conexaoBiblioteca = new conectandoMongoDB();

        //     Console.WriteLine(" ");
        //     Console.WriteLine(" -------------------- Condição simples------------------------ ");
        //     Console.WriteLine(" ");

        //     var filtro = new BsonDocument{
        //         {"Assunto","c#"}
        //     };
        //     var listaLivros = await conexaoBiblioteca.Livros.Find(filtro).ToListAsync();

        //     foreach (var doc in listaLivros)
        //     {
        //         Console.WriteLine(doc.ToJson<Livro>());
        //     }

        //     Console.WriteLine(" ");
        //     Console.WriteLine(" ------------------- Utilizando recursos do Bsom (Eq = Igual)------------------------- ");
        //     Console.WriteLine(" ");


        //     var construtor = Builders<Livro>.Filter;
        //     var condicao = construtor.Eq(x => x.Titulo, "Titulo");
        //     var ClassLivros = await conexaoBiblioteca.Livros.Find(condicao).ToListAsync();

        //     foreach (var doc in ClassLivros)
        //     {
        //         Console.WriteLine(doc.ToJson<Livro>());
        //     }


        //     Console.WriteLine(" ");
        //     Console.WriteLine(" ------------------ Utilizando recursos do Bsom (Gte = Igual ou Maio com 2 condiçoes)-------------------------- ");
        //     Console.WriteLine(" ");



        //     var collection = Builders<Livro>.Filter;
        //     var filter = construtor.Gte(x => x.Ano, 1992) & collection.Gte(x => x.Paginas, 29);
        //     var retorno = await conexaoBiblioteca.Livros.Find(filter).ToListAsync();

        //     foreach (var doc in retorno)
        //     {
        //         Console.WriteLine(doc.ToJson<Livro>());
        //     }

        //     Console.WriteLine(" ");
        //     Console.WriteLine(" ------------------ Recuperando a partir de uma sublista do mongoDb-------------------------- ");
        //     Console.WriteLine(" ");



        //     var col = Builders<Livro>.Filter;
        //     //AnyEq  propriedade que busca dentro de uma Array/Lista
        //     var fil = construtor.AnyEq(x => x.Assunto, "csharp");
        //     var ret = await conexaoBiblioteca.Livros.Find(fil).ToListAsync();

        //     foreach (var doc in ret)
        //     {
        //         Console.WriteLine(doc.ToJson<Livro>());
        //     }

        //     Console.WriteLine(" ");
        //     Console.WriteLine(" -------------------------------------------- ");
        //     Console.WriteLine(" ");
        //     Console.WriteLine("Fim da lista");

        // }
        #endregion

        #region Programa Recuperando a partir de uma class do Banco MongoDb
        // static void Main(string[] args)
        // {
        //     //chamada inicial do codigo
        //     //chama um metodo assincrono "mainSync"
        //     //que executa a rotina de consulta ao banco de dados.
        //     Task T = MainSync(args);


        //     Console.WriteLine("Testando comando");
        //     Console.ReadLine();
        // }
        // //Metodo assincrono chamado na inicialização do sistema.
        // static async Task MainSync(string[] args)
        // {
        //     //chama o metodo responsavel pela conexao ao banco de dados
        //     var conexaoBiblioteca = new conectandoMongoDB();
        //     //consulta por uma class especifica (no nosso caso a class Livro)
        //     var collection = Builders<Livro>.Filter;
        //     //executa o filtro e acordo com a regra de negocio
        //     var filter = collection.Gte(x => x.Ano, 1992) & collection.Gte(x => x.Paginas, 29);
        //     //retorna o valor da consulta
        //     //Repare que apos a consulta antes de retornar o objeto temos varios recursos, um deles e o sortBy 
        //     //que ordeda por uma condição, no nosso caso vai ordenar por titulo.
        //     //Sortby = Ordenado por...
        //     //Limit = limita a quantidade de objetos retornados.
        //     var retorno = await conexaoBiblioteca.Livros.Find(filter).SortBy(x =>x.Titulo).Limit(2).ToListAsync();

        //     //no nosso caso cria uma lista de livros no console
        //     foreach (var doc in retorno)
        //     {
        //         Console.WriteLine(doc.ToJson<Livro>());
        //     }

        //     Console.WriteLine(" ");
        //     Console.WriteLine(" -------------------------------------------- ");
        //     Console.WriteLine(" ");
        //     Console.WriteLine("Fim da lista");

        // }
        #endregion

        #region Limpando o codigo, Utilizando o busca por Class e filtro Linq devolvendo uma lista que é impressa no console.
        // static void Main(string[] args)
        // {
        //     Task T = funcaoGenericaAsync();
        //     Console.WriteLine("Função assincrona acima, foi iniciada e o programa continuaou.");
        //     Console.ReadLine();
        // }
        // //Metodo assincrono chamado na inicialização do sistema.
        // static async Task funcaoGenericaAsync()
        // {
        //     var conexaoBiblioteca = new conectandoMongoDB();

        //     var collection = Builders<Livro>.Filter;
        //     var filter = collection.Gte(x => x.Ano, 1992) & collection.Gte(x => x.Paginas, 25);
        //     var retorno = await conexaoBiblioteca.Livros.Find(filter).SortBy(x =>x.Titulo).Limit(2).ToListAsync();

        //     foreach (var doc in retorno)
        //     {
        //         Console.WriteLine(doc.ToJson<Livro>());
        //     }

        //     Console.WriteLine("Fim da função");
        // }
        #endregion

        #region Alterando documento Utilizando o Filter.
        // static void Main(string[] args)
        // {
        //     Task T = funcaoGenericaAsync();
        //     Console.WriteLine("Função assincrona acima, foi iniciada e o programa continuaou.");
        //     Console.ReadLine();
        // }
        // //Metodo assincrono chamado na inicialização do sistema.
        // static async Task funcaoGenericaAsync()
        // {
        //     var conexaoBiblioteca = new conectandoMongoDB();

        //     var collection = Builders<Livro>.Filter;
        //     var filter = collection.Eq(x => x.Titulo, "Titulo do filme 8");

        //     var retorno = await conexaoBiblioteca.Livros.Find(filter).ToListAsync();
        //     foreach (var doc in retorno)
        //     {
        //         Console.WriteLine(doc.ToJson<Livro>());
        //         //Incerindo novos valores
        //         doc.Ano = 2000;
        //         doc.Paginas = 900;
        //         //Salvando novos valores no banco mongoDb
        //         await conexaoBiblioteca.Livros.ReplaceOneAsync(filter, doc);
        //     }

        //     Console.WriteLine(" -------------- Registro atualizado --------------");

        //     // Listando o registor que foi alterado
        //     var collectio = Builders<Livro>.Filter;
        //     var filte = collection.Eq(x => x.Titulo, "Titulo do filme 8");

        //     var retorn = await conexaoBiblioteca.Livros.Find(filte).ToListAsync();
        //     foreach (var doc in retorn)
        //     {
        //         Console.WriteLine(doc.ToJson<Livro>());
        //     }

        //     Console.WriteLine("Fim da função");
        // }
        #endregion

        #region Alterando documento Utilizando o Update.
        // static void Main(string[] args)
        // {
        //     Task T = funcaoGenericaAsync();
        //     Console.WriteLine("Função assincrona acima, foi iniciada e o programa continuaou.");
        //     Console.ReadLine();
        // }
        // //Metodo assincrono chamado na inicialização do sistema.
        // static async Task funcaoGenericaAsync()
        // {
        //     var conexaoBiblioteca = new conectandoMongoDB();

        //     var collection = Builders<Livro>.Filter;
        //     var filter = collection.Eq(x => x.Titulo, "Titulo do filme 8");

        //     //Controi o objeto no formtao Livro
        //     var retorno = await conexaoBiblioteca.Livros.Find(filter).ToListAsync();

        //     Console.WriteLine(retorno.ToJson());

        //     // Contrutor de registro "Update" diferente do utilizado anteriormente que erra "Filter"
        //     // O que muda e que cada um libera recursos diferentes
        //     var collectio = Builders<Livro>.Update;
        //     var filte = collectio.Set(x => x.Ano, 1999);
        //     //Injetado o objeto antigo e o ojeto novo.
        //     await conexaoBiblioteca.Livros.UpdateOneAsync(filter, filte);


        //     Console.WriteLine("---------------");
        //     Console.WriteLine("Atualização realizada");
        //     Console.WriteLine("---------------");

        //     //Recuperando registro atualizado do banco.
        //     var collecti = Builders<Livro>.Filter;
        //     var filt = collecti.Eq(x => x.Titulo, "Titulo do filme 8");
        //     var reto = await conexaoBiblioteca.Livros.Find(filt).ToListAsync();
        //     Console.WriteLine(reto.ToJson());

        // }
        #endregion

        #region Alterando documento Utilizando o Update em Lote.
        // static void Main(string[] args)
        // {
        //     Task T = funcaoGenericaAsync();
        //     Console.WriteLine("Função assincrona acima, foi iniciada e o programa continuaou.");
        //     Console.ReadLine();
        // }
        // //Metodo assincrono chamado na inicialização do sistema.
        // static async Task funcaoGenericaAsync()
        // {
        //     var conexaoBiblioteca = new conectandoMongoDB();

        //     //Recupera todos os registros que atendem a condição do filtro
        //     var collection = Builders<Livro>.Filter;
        //     var filter = collection.Eq(x => x.Paginas, 35);
        //     var retorno = await conexaoBiblioteca.Livros.Find(filter).ToListAsync();
        //     foreach (var item in retorno)
        //     {
        //         Console.WriteLine(item.ToJson());
        //     }

        //     // Contrutor de registro "Update".
        //     var collectio = Builders<Livro>.Update;
        //     var filte = collectio.Set(x => x.Paginas, 29);
        //     //Gravando os registros atualizados, baseado na chamada anterior do Filter que retornou todos os registros que atendiam a condição
        //     await conexaoBiblioteca.Livros.UpdateManyAsync(filter, filte);


        //     Console.WriteLine("---------------");
        //     Console.WriteLine("Atualização realizada");
        //     Console.WriteLine("---------------");

        //     //Recuperando registro atualizado do banco e imprimiu no console.
        //     var collecti = Builders<Livro>.Filter;
        //     var filt = collecti.Eq(x => x.Paginas, 29);
        //     var reto = await conexaoBiblioteca.Livros.Find(filt).ToListAsync();

        //     foreach (var ite in reto)
        //     {
        //         Console.WriteLine(ite.ToJson());
        //     }

        // }
        #endregion

        #region Deletando documento em Lote.
        // static void Main(string[] args)
        // {
        //     Task T = funcaoGenericaAsync();
        //     Console.WriteLine("Função assincrona acima, foi iniciada e o programa continuaou.");
        //     Console.ReadLine();
        // }
        // //Metodo assincrono chamado na inicialização do sistema.
        // static async Task funcaoGenericaAsync()
        // {
        //     var conexaoBiblioteca = new conectandoMongoDB();

        //     //Recupera todos os registros que atendem a condição do filtro
        //     var collection = Builders<Livro>.Filter;
        //     var filter = collection.Eq(x => x.Paginas, 15);
        //     var retorno = await conexaoBiblioteca.Livros.Find(filter).ToListAsync();
        //     foreach (var item in retorno)
        //     {
        //         Console.WriteLine(item.ToJson());
        //     }

        //     // Deletando os registros recuperados pelo Filter, consulta a cima.

        //     await conexaoBiblioteca.Livros.DeleteManyAsync(filter);

        //     Console.WriteLine("---------------");
        //     Console.WriteLine("Recuperando dados do banco");
        //     Console.WriteLine("---------------");

        //     //Recuperando registro atualizado do banco e imprimiu no console.
        //     collection = Builders<Livro>.Filter;
        //     filter = collection.Eq(x => x.Paginas, 15);
        //     retorno = await conexaoBiblioteca.Livros.Find(filter).ToListAsync();

        //     foreach (var ite in retorno)
        //     {
        //         Console.WriteLine(ite.ToJson());
        //     }

        // }
        #endregion

       
    }
}
