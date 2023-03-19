
int[] vetor = new int[5];
int i;

Console.WriteLine("Olá usuário! Por gentileza, insira 5 números inteiros");

for (i = 0; i < 5; i++)
{
    Console.WriteLine("Número " + (i + 1));
    vetor[i] = Convert.ToInt32(Console.ReadLine());

}

int menorvalor = vetor[0];
int maiorvalor = vetor[0];

for (i = 1; i < 5; i++)
{
    if (menorvalor > vetor[i])
    {
        menorvalor = vetor[i];
    }
    if (maiorvalor < vetor[i])
    {
        maiorvalor = vetor[i];
    }
}
Console.WriteLine("Maior valor: " + maiorvalor);
Console.WriteLine("Menor valor: " + menorvalor);