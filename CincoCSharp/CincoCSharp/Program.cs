
Console.WriteLine("Caro usuário, pedimos por gentileza que insira o nome de 3 alunos desejados");
string[,] alunos = new string[3, 3];

string aluno1;
string aluno2;
string aluno3;
double[] notaAluno1 = new double[4];
double[] notaAluno2 = new double[4];
double[] notaAluno3 = new double[4];

aluno1 = Console.ReadLine();
aluno2 = Console.ReadLine();
aluno3 = Console.ReadLine();


//insira notas aluno 1
double mediaaluno1 = 0;
double mediaaluno2 = 0;
double mediaaluno3 = 0;

Console.WriteLine("Insira as 4 notas do aluno "+ aluno1);
for (int i = 0; i < 4; i++)
{
    notaAluno1[i] = Convert.ToDouble(Console.ReadLine());
    double somamediaaluno1 = notaAluno1[0] + notaAluno1[1] + notaAluno1[2] + notaAluno1[3];
    mediaaluno1 = somamediaaluno1 / 4;  
}
Console.WriteLine("Insira as 4 notas do aluno " + aluno2);
//insira notas aluno 2
for (int i = 0; i < 4; i++)
{
    notaAluno2[i] = Convert.ToDouble(Console.ReadLine());
    double somamediaaluno2 = notaAluno2[0] + notaAluno2[1] + notaAluno2[2] + notaAluno2[3];
    mediaaluno2 = somamediaaluno2 / 4;
}
Console.WriteLine("Insira as 4 notas do aluno " + aluno3);
for (int i = 0; i < 4; i++)
{
    //insira notas aluno 3
    notaAluno3[i] = Convert.ToDouble(Console.ReadLine());
    double somamediaaluno3 = notaAluno3[0] + notaAluno3[1] + notaAluno3[2] + notaAluno3[3];
    mediaaluno3 = somamediaaluno3 / 4;
}

alunos[0, 0] = aluno1;
alunos[0, 1] = Convert.ToString(mediaaluno1);

alunos[1, 0] = aluno2;
alunos[1, 1] = Convert.ToString(mediaaluno2);

alunos[2, 0] = aluno3;
alunos[2, 1] = Convert.ToString(mediaaluno3);

string alunosvar = "";
for (int linha = 0; linha < 3; linha++)
{
    for (int coluna = 0; coluna < 3; coluna++)
    {
  
        alunosvar += alunos[linha, coluna] + " ";
    }
    Console.WriteLine(alunosvar);
    alunosvar = " ";
}

if (mediaaluno1 > mediaaluno2 && mediaaluno1 > mediaaluno3)
{
    Console.WriteLine("Maior média é do aluno " + aluno1 + " com uma média de " + mediaaluno1);
}
else if (mediaaluno2 > mediaaluno1 && mediaaluno2 > mediaaluno3)
{
    Console.WriteLine("Maior média é do aluno " + aluno2 +" com uma média de "+ mediaaluno2 );
}
else if (mediaaluno3 > mediaaluno1 && mediaaluno3 > mediaaluno2)
{
    Console.WriteLine("Maior média é do aluno " + aluno3 + " com uma média de " + mediaaluno3);
}
if (mediaaluno1 < mediaaluno2 && mediaaluno1 < mediaaluno3)
{
    Console.WriteLine("Menor média é do aluno " + aluno1 + " com uma média de " + mediaaluno1);
}
else if (mediaaluno2 < mediaaluno1 && mediaaluno2 < mediaaluno3)
{
    Console.WriteLine("Menor média é do aluno " + aluno2 + " com uma média de " + mediaaluno2);
}
else if (mediaaluno3 < mediaaluno1 && mediaaluno3 < mediaaluno2)
{
    Console.WriteLine("Menor média é do aluno " + aluno3 + " com uma média de " + mediaaluno3);
}
if (mediaaluno1 == mediaaluno2 && mediaaluno2 == mediaaluno3)
{
    Console.WriteLine("Todas as medias são iguais");
}
else if (mediaaluno1==mediaaluno2)
{
    Console.WriteLine("As médias do aluno "+aluno1 +" e do aluno "+aluno2 +" são iguais, sendo: " + mediaaluno1);
}
else if (mediaaluno2 == mediaaluno3)
{
    Console.WriteLine("As médias do aluno " + aluno2 + " e do aluno " + aluno3 + " são iguais, sendo: " + mediaaluno2);
}
else if (mediaaluno3 == mediaaluno1)
{
    Console.WriteLine("As médias do aluno " + aluno3 + " e do aluno " + aluno1 + " são iguais, sendo: " + mediaaluno3);
}
