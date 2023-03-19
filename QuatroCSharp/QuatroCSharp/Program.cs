Console.WriteLine("Olá usuário! Por gentileza, insira 5 números inteiros");

int[] numeros = new int[5];
for (int i = 0; i < 5; i++)
{

    Console.WriteLine("Número " + (i + 1));
    numeros[i] = Convert.ToInt32(Console.ReadLine());

}
Console.WriteLine("Este é o 3° número digitado");
Console.WriteLine(numeros[2]);