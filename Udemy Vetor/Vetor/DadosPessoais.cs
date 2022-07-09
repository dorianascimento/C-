
namespace Vetor
{
    public class DadosPessoais
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public int Quarto { get; set; }

        public DadosPessoais(string nome, string email, int quarto)
        {
            Nome = nome;
            Email = email;
            Quarto = quarto;
        }

        public void Apresentar(int numero)
        {
            Console.WriteLine("{0}: {1}, {2}", numero, Nome, Quarto);
        }
    }
}
