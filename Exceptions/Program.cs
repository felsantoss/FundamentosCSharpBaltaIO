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
// Exception para trativa de forma genérica
catch(Exception ex)
{
    Console.WriteLine("Algo deu errado!");
    Console.WriteLine(ex.InnerException);
    Console.WriteLine(ex.Message);
}