var arr = new int[3];

try 
{
    for ( int i = 0; i  < 10; i ++)
    {
        Console.WriteLine(arr[i]);
    }
}
// Tipo especifico de Exception
catch(IndexOutOfRangeException ex)
{
    Console.WriteLine(ex.InnerException);
    Console.WriteLine(ex.Message);
    Console.WriteLine("Item excede a lista atual");
}
catch(ArgumentNullException ex)
{
    Console.WriteLine(ex.InnerException);
    Console.WriteLine(ex.Message);
    Console.WriteLine("Falha ao cadastrar");
}

// Exception para trativa de forma genérica
catch(Exception ex)
{
    Console.WriteLine("Algo deu errado!");
    Console.WriteLine(ex.InnerException);
    Console.WriteLine(ex.Message);
} 
// Sempre será executado
finally
{
    Console.WriteLine("Fim do programa.");
}

Cadastrar(""); 

static void Cadastrar(string texto)
{
    if (string.IsNullOrEmpty(texto))
    {
        throw new ArgumentNullException("O texto não pode ser nulo ou vazio");
    }
}