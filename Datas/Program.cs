using System.Globalization;

// Data atual
var dataAtual = DateTime.Now;

// Especificando uma data
var data = new DateTime(2024, 02, 15, 07, 12, 30); 

// Data formatada
var dataFormatada = String.Format("{0:yyyy/MM/dd hh:mm:ss z}", dataAtual);
Console.WriteLine(dataFormatada);

var dataPadrao = String.Format("{0:u}", dataAtual);
Console.WriteLine(dataPadrao);

Console.WriteLine(dataAtual);
Console.WriteLine(data.DayOfYear);
Console.WriteLine(data.DayOfWeek); 

// Adicionando dia, mês e ano
Console.WriteLine(dataAtual.AddDays(12));
Console.WriteLine(dataAtual.AddMonths(1));
Console.WriteLine(dataAtual.AddYears(1));

// Quantidade de dias que um determinado mês possui
Console.WriteLine(DateTime.DaysInMonth(2024, 2));

// Atribuindo um tipo de cultura
var uk = new CultureInfo("en-UK");
var pt = new CultureInfo("pt-PT");
var us = new CultureInfo("en-US");
var jp = new CultureInfo("ja-JP");

// Cultura atual da máquina
var atual = CultureInfo.CurrentCulture;

Console.WriteLine(DateTime.Now.ToString("D", uk));
Console.WriteLine(DateTime.Now.ToString("D", pt));
Console.WriteLine(DateTime.Now.ToString("D", us));
Console.WriteLine(DateTime.Now.ToString("D", jp));

var dataUTC = DateTime.UtcNow;
Console.WriteLine(dataUTC.ToLocalTime());

// Armazenando o timezone da Australia
var timeZoneAustralia = TimeZoneInfo.FindSystemTimeZoneById("Pacific/Auckland");
Console.WriteLine(timeZoneAustralia);

// Convertendo o horário para o timezone da Australia
var horaAustralia = TimeZoneInfo.ConvertTimeFromUtc(dataUTC, timeZoneAustralia);
Console.WriteLine(horaAustralia);

// Imprimindo todos os timezones cadastrados
var timeZones = TimeZoneInfo.GetSystemTimeZones();
foreach (var timezone in timeZones)
{
    Console.WriteLine(timezone.Id);
    Console.WriteLine(timezone);
    Console.WriteLine(TimeZoneInfo.ConvertTimeFromUtc(dataUTC, timezone));
    Console.WriteLine("______");
}