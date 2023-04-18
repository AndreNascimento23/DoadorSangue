Console.Clear();

int idade;

Console.Write("Qual a sua Idade? ");
idade = Int32.Parse(Console.ReadLine()!);

bool doador = idade >= 18 && idade <= 67;

if (doador)
{
    Console.WriteLine("Você pode ser doador de sangue.");
    Environment.Exit(-1);
}

Console.WriteLine("Você não pode ser Doador de sangue !!");
