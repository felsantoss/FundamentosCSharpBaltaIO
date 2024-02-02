static void Somar()
{
    Console.WriteLine("Método Somar\n");
    Console.WriteLine("Insira o primeiro valor:");
    double firstValue = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Insira o segundo valor:");
    double secondValue = Convert.ToDouble(Console.ReadLine());

    double result = firstValue + secondValue;

    Console.WriteLine($"{firstValue} + {secondValue} = {result}");
}

static void Subtratir()
{
    Console.WriteLine("Método Subtratir\n");

    Console.WriteLine("Insira o primeiro valor:");
    double firstValue = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Insira o segundo valor:");
    double secondValue = Convert.ToDouble(Console.ReadLine());

    double result = firstValue - secondValue;

    Console.WriteLine($"{firstValue} - {secondValue} = {result}");
}

static void Multiplicar()
{
    Console.WriteLine("Método Multiplicar\n");

    Console.WriteLine("Insira o primeiro valor:");
    double firstValue = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Insira o segundo valor:");
    double secondValue = Convert.ToDouble(Console.ReadLine());

    double result = firstValue * secondValue;

    Console.WriteLine($"{firstValue} * {secondValue} = {result}");
}

static void Dividir()
{
    Console.WriteLine("Método Dividir\n");

    Console.WriteLine("Insira o primeiro valor:");
    double firstValue = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Insira o segundo valor:");
    double secondValue = Convert.ToDouble(Console.ReadLine());

    double result = firstValue / secondValue;

    Console.WriteLine($"{firstValue} / {secondValue} = {result}");
}

bool restart = true;

while (restart)
{
    Console.WriteLine("Qual operação deseja realizar?\n");

    Console.WriteLine("Digite * para multiplicar, / para dividir, + para somar e - para subtrair.");
    string operation = Console.ReadLine();

    switch (operation)
{
    case "*": 
    Multiplicar();
    break;

    case "/":
    Dividir();
    break;

    case "+":
    Somar();
    break;

    case "-":
    Subtratir();
    break;

    default: 
    Console.WriteLine("Operação não encontrada");
    break;
}

    Console.WriteLine("Deseja reiniciar o programa? s/n");
    string response = Console.ReadLine();

    restart = response.ToLower() == "s";
}