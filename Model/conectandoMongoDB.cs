using MongoDB.Driver;



namespace Curso_Mongodb_Net.Model
{
    public class conectandoMongoDB
    {

        public conectandoMongoDB()
        {
            _cliente = new MongoClient(STRING_DE_CONEXAO);
            _BaseDeDados = _cliente.GetDatabase(NOME_DA_BASE);
        }
        public const string STRING_DE_CONEXAO = "mongodb://localhost:27017";
        public const string NOME_DA_BASE = "Biblioteca";
        public const string NOME_DA_COLECAO = "Livros";


        private readonly IMongoClient _cliente;
        private readonly IMongoDatabase _BaseDeDados;

        public IMongoClient Cliente{
            get {return _cliente;}
        }
        public IMongoCollection<Livro> Livros{
            get{return _BaseDeDados.GetCollection<Livro>(NOME_DA_COLECAO);}
        }

    }
}