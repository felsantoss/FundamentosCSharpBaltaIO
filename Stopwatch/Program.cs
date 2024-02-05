static void Start(int time)
{
    int currentTime = 0;

    while(currentTime != time)
    {
        Console.Clear();

        currentTime++;
        Console.WriteLine($"{currentTime} segundos");

        Thread.Sleep(1000); // função para a execução em console ser de 1 em 1 segundo
    }
}

static void Timer(int timer)
{
    int currentTime = 0;

    while (currentTime != timer)
    {
        Console.Clear();

        timer--;
        Console.WriteLine($"{timer} segundos");

        Thread.Sleep(1000);
    }
}

static void ChoiceMenu()
{
    Console.Clear();

    Console.WriteLine("Qual função deseja utilizar?\n");
    Console.WriteLine("1 = Cronometro");
    Console.WriteLine("2 = Timer");

    int choice = Convert.ToInt32(Console.ReadLine());

    switch(choice)
    {
        case 1: 
        CountChoice();
        break;

        case 2:
        TimerChoice();
        break;

        default:
        Console.Write("Função não localizada.");
        break;
    }
}

static void TimerChoice()
{
    Console.Clear();

    Console.WriteLine("Timer");

    Console.WriteLine("S = Segundos => 10s = 10 segundos");
    Console.WriteLine("M = Minutos => 1m = 1 minuto");
    Console.WriteLine("0 = Sair");

    Console.WriteLine("Quanto tempo deseja contar?");

    string data = Console.ReadLine().ToLower();
    
    char type = char.Parse(data.Substring(data.Length - 1, 1)); // pegando o último caracterer digitado
    int time = int.Parse(data.Substring(0, data.Length - 1)); // pegando todas os caracteres menos o último

    int multiplier = 1;

    if (type == 'm')
        multiplier = 60;
    
    if (time == 0)
        System.Environment.Exit(0);

    Timer(time * multiplier);
}

static void CountChoice()
{
    Console.Clear();

    Console.WriteLine("Cronometro");

    Console.WriteLine("S = Segundos => 10s = 10 segundos");
    Console.WriteLine("M = Minutos => 1m = 1 minuto");
    Console.WriteLine("0 = Sair");

    Console.WriteLine("Quanto tempo deseja contar?");

    string data = Console.ReadLine().ToLower();
    
    char type = char.Parse(data.Substring(data.Length - 1, 1)); // pegando o último caracterer digitado
    int time = int.Parse(data.Substring(0, data.Length - 1)); // pegando todas os caracteres menos o último

    int multiplier = 1;

    if (type == 'm')
        multiplier = 60;
    
    if (time == 0)
        System.Environment.Exit(0);

    Start(time * multiplier);
}

ChoiceMenu();