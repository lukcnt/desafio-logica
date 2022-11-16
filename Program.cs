Console.WriteLine("Digite a quantidade de notas a ser calculada:");
int quantidadeNotas = Convert.ToInt32(Console.ReadLine());

double somaDasNotas = 0;
for (int contador = 1; contador <= quantidadeNotas; contador++)
{
    Console.WriteLine($"Digite a {contador}ª nota:");
    double nota = Convert.ToDouble(Console.ReadLine());
    somaDasNotas += nota;
}

double mediaFinal = somaDasNotas / quantidadeNotas;

if (mediaFinal >= 6)
{
    Console.WriteLine($"A média do aluno foi de: {mediaFinal}");
    Console.WriteLine("Parabéns, você passou!");
}
else
{
    Console.WriteLine($"A média do aluno foir de: {mediaFinal}");
    Console.WriteLine("Infelizmente você ficou de recuperação!");
}