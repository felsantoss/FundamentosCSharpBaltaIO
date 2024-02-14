string texto = "Este texto é apenas um teste";

Console.WriteLine(texto.StartsWith("Este")); // true
Console.WriteLine(texto.StartsWith("este", StringComparison.OrdinalIgnoreCase)); // ignora case sensitive - true

Console.WriteLine(texto.EndsWith("teste")); // true
Console.WriteLine(texto.EndsWith("Teste")); // false

Console.Clear();

Console.WriteLine(texto.IndexOf("Este")); // retorna a posição do indice dentro da string
Console.WriteLine(texto.LastIndexOf("s")); // retorna a última posição da letra encontrada dentro da string