namespace Course
{
    public class Dados
    {
        public string Nome;
        public int Idade;
        public double Altura;

        public Dados(string nome, int idade, double altura)
        {
            Nome = nome;
            Idade = idade;
            Altura = altura;
        }

        public override string ToString()
        {
            return "Dados pessoais, Nome: " + Nome + ", Idade: " + Idade + ", Altura: " + Altura;
        }
    }
}