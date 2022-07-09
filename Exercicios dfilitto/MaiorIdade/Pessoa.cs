
namespace MaiorIdade
{
    public class Pessoa
    {
        public int Idade { get; set; }
        public string Nome { get; set; }

        public Pessoa()
        {
        }
        public Pessoa(string nome, int idade)
        {
            Idade = idade;
            Nome = nome;
        }

        public void ExibirDados()
        {
            Console.WriteLine("Nome: "+ Nome +", Idade: "+ Idade);
        }
    }
}
