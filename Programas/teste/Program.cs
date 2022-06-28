// metodos para array


using System;

class Program
{
    static void Main()
    {
        int[] vetor1 = new int[5];
        int[] vetor2 = new int[5]; 
        int[] vetor3 = new int[5];
        int[,] matriz = new int[2, 5] {{ 1, 2, 3, 4, 5 },{ 6, 7, 8, 9, 10}};

        Random randow = new Random();
        for (int i = 0; vetor1.Length; i++)
        {
            vetor1[i] = randow.Next(50);
        }

        Console.WriteLine("Elementos do vetor 1");
        foreach(int n in vetor1)
        {
            Console.WriteLine(n);
        }

        // public static int BinarySearch(array,valor);
        Console.WriteLine("BinarySearch");
        int procurado = 33;
        int pos = Array.BinarySearch(vetor1 , procurado);
        Console.WriteLine("Valor {0} está na posiçao {1}", procurado, pos);
        Console.WriteLine("---------------------------------------------");

        // public static void Copy(Ar_origem, Ar_destino, qtde_elementos);
        Console.WriteLine("copy");
        Array.Copy(vetor1, vetor2, vetor1.Length);
        foreach( int n in vetor2)
        {
            Console.WriteLine(n);
        }
        Console.WriteLine("---------------------------------------------");

        // public void CopyTo(Ar_destino, a_parir_desta_pos);
        Console.WriteLine("CopyTo");
        vetor1.CopyTo(vetor3);
        foreach ( int n in vetor3)
        { 
            Console.WriteLine(n);
        }
        Console.WriteLine("---------------------------------------------");

        //public int GetLowerBound(dimensão)
        // vai retornar menor indice do array, se for array dimensão = 0 
        Console.WriteLine("GetLowerBound");
        int MenorIndiceVetor = vetor1.GetLowerBound(0);
        int MenorIndiceMatriz = matriz.GetLowerBound(1);
        Console.WriteLine("Menor indice do vetor {0}", MenorIndiceVetor);
        Console.WriteLine("Menor indice matriz {0}", MenorIndiceMatriz);
        Console.WriteLine("----------------------------------------------");

        //public int GetUpperBound(dimensão)
        // retorna o maior indice, array dimensão = 0, matriz = depende do tamanho da matriz, especificar o tamanho
        Console.WriteLine("GetUpperBound");
        int MaiorIndiceVetor = vetor1.GetUpperBound(0);
        int MaiorIndiceMatriz = matriz.GetUpperBound(1);
        Console.WriteLine("Maior indice do array {0}", MaiorIndiceVetor);
        ConsoleWriteLine("------------------------------------------------");

        //public object GetValue(long indice);
        //vai retornar um valro a partir de um indice
        Console.Write("GetValue");
        int valor0 = Convert.ToInt32(vetor1.GetValue(3));
        int valor1 = Convert.ToInt32(matriz.GetValue(1, 2));
        Console.WriteLine("Valor da posição 3 do vetor1: {0}", valor0);
        Console.WriteLine("------------------------------------------------");



        


}
