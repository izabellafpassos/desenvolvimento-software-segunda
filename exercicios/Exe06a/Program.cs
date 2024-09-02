//1 criar uma variavel ou um vetor
//2 criar um laço para percorrer o vetor
//3 para cada posiçao gerar um valor aleatorio
//4 ordenar o vetor
class Program
{
    static void Main()
    {
        int[] numeros = new int[100];
        Random random = new Random();

        for (int i = 0; i < numeros.Length; i++)
        {
            numeros[i] = random.Next(100);

        }
        for (int i = 0; i < numeros.Length - 1; i++)
        {
            numeros[i] = random.Next(100);
            if (numeros[i] > numeros[i + 1])
            {
                int aux = numeros[i];
                numeros[i] = numeros[i + 1];
                numeros[i + 1] = aux;


            }
        }
        for (int i = 0; i < numeros.Length; i++)
        {
            Console.Write(numeros[i] + " ");

        }
    }

}

