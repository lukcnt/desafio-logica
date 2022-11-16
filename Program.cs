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