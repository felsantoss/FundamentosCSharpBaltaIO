var arr = new int[3];

try 
{
    for ( int i = 0; i  < 10; i ++)
    {
        Console.WriteLine(arr[i]);
    }
}
catch(Exception ex)
{
    Console.WriteLine("Algo deu errado!");
    Console.WriteLine(ex.InnerException);
    Console.WriteLine(ex.Message);
}
