// Data atual
var dataAtual = DateTime.Now;

// Especificando uma data
var data = new DateTime(2024, 02, 15, 07, 12, 30); 

// Data formatada
var dataFormatada = String.Format("{0:yyyy/MM/dd hh:mm:ss z}", dataAtual);
Console.WriteLine(dataFormatada);

var dataPadrao = String.Format("{0:u}", dataAtual);
Console.WriteLine(dataPadrao);

/*
Console.WriteLine(dataAtual);
Console.WriteLine(data.DayOfYear);
Console.WriteLine(data.DayOfWeek); */

// Adicionando dia, mês e ano
Console.WriteLine(dataAtual.AddDays(12));
Console.WriteLine(dataAtual.AddMonths(1));
Console.WriteLine(dataAtual.AddYears(1));