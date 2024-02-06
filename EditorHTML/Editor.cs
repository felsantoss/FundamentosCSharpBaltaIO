using System.Text;

public class Editor()
{
    public static void Show()
    {
        Console.Clear();

        Console.BackgroundColor = ConsoleColor.White;
        Console.ForegroundColor = ConsoleColor.Black;

        Console.Clear();

        Console.WriteLine("Modo Editor");
        Console.WriteLine("---------");

        Start();
    }

    public static void Start()
    {
        var file = new StringBuilder();

        do {
            file.Append(Console.ReadLine());
            file.Append(Environment.NewLine);
        }
        while(Console.ReadKey().Key != ConsoleKey.Escape);

        Console.WriteLine("---------");
        Console.WriteLine("Deseja salvar o arquivo?"); // TODO (opção de sim ou não do usuário, Não perde o arquivo e Sim chama o visualizador de arquivo)
    }
}