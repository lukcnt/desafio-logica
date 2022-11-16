bool continuarPrograma = true;

while (continuarPrograma)
{
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
    mediaFinal = Math.Round(mediaFinal, 2);
    if (mediaFinal >= 6)
    {
        Console.WriteLine($"\nA média do aluno foi de: {mediaFinal}");
        Console.WriteLine("Parabéns, você passou!");
    }
    else
    {
        Console.WriteLine($"\nA média do aluno foi de: {mediaFinal}");
        Console.WriteLine("Infelizmente você ficou de recuperação!");
    }

    Console.WriteLine("\nDeseja calcular outra média?");
    Console.WriteLine("Digite 1 para Sim");
    string? continuar = Console.ReadLine();
    if (continuar == "1")
    {
        continuarPrograma = true;
    }
    else
    {
        continuarPrograma = false;
    }
}