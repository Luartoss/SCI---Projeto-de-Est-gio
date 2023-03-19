
string condicao;

Console.WriteLine("Digite 1 para inserir um aluno e qualquer outro botão para encerrar o programa");
condicao = Console.ReadLine();

string aluno;
double[] nota= new double[4];
double media;
double soma;
double nota2;

while (condicao=="1")
{
    Console.WriteLine("Insira o nome do aluno");
    aluno = Console.ReadLine();

    Console.WriteLine("Nota 1");
    nota[0] = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Nota 2");
    nota[1] = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Nota 3");
    nota[2] = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Nota 4");
    nota[3] = Convert.ToDouble(Console.ReadLine());

    
    soma = nota[0] + nota[1] + nota[2] + nota[3];
    media = soma / 4;
    
    Console.WriteLine("A média do aluno " + aluno + " é "+ media);
    if (media >= 6)
    {
        Console.WriteLine("Aprovado");
    }
    else
    {
        Console.WriteLine("Reprovado");
    }
     
    Console.WriteLine("Digite 1 para continuar e qualquer outro botão para encerrar");
    condicao = Console.ReadLine();
    
}
