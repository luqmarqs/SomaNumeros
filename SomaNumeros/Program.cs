Console.Write("Digite um número natural: ");

int n = int.Parse(Console.ReadLine());

int soma = 0;

for(int i = 0; i <= n; i++)
{
    if (i % 3 == 0 || i % 5 == 0)
        soma += i;
}

Console.WriteLine($"A soma dos múltiplos de 3 e 5 é {soma}");