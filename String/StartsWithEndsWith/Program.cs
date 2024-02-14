string texto = "Este texto é apenas um teste";

Console.WriteLine(texto.StartsWith("Este")); // true
Console.WriteLine(texto.StartsWith("este", StringComparison.OrdinalIgnoreCase)); // ignora case sensitive - true

Console.WriteLine(texto.EndsWith("teste")); // true
Console.WriteLine(texto.EndsWith("Teste")); // false