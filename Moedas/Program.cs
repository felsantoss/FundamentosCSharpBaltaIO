using System.Globalization;

decimal valor = 25.50m;

// Convertendo o valor da moeda informando uma cultura especifica
Console.WriteLine(valor.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));

// Arredonda o número 
Console.WriteLine(Math.Round(valor));

// Arredonda para cima
Console.WriteLine(Math.Ceiling(valor));

// Arredonda para baixo
Console.WriteLine(Math.Floor(valor));