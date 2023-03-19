
int[] vetor = new int[5];
List<int> listapar = new List<int>();
List<int> listaimpar = new List<int>();

Console.WriteLine("Olá usuário! Por gentileza, insira 5 números inteiros");
for (int i = 0; i < 5; i++)
{

    Console.WriteLine("Número " + (i + 1));
    vetor[i] = Convert.ToInt32(Console.ReadLine());

    if (vetor[i] % 2 == 0)
    {
        listapar.Add(vetor[i]);
    }
    else
    {
        listaimpar.Add(vetor[i]);
    }

}
Console.WriteLine("Números pares");
listapar.ForEach(Console.WriteLine);
Console.WriteLine("Números ímpares");
listaimpar.ForEach(Console.WriteLine);
Console.WriteLine("Média da soma dos números pares e ímpares");
double soma = vetor[0] + vetor[1] + vetor[2] + vetor[3] + vetor[4];
double media = soma / 5;
Console.WriteLine(media);