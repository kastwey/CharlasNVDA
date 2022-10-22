using System.Globalization;
using DayOfWeek;

int day, month, year;

Console.WriteLine("¡Vamos a calcular el día de la semana de la fecha que quieras!");

do {
	Console.WriteLine(" Introduce el día (escribe números del 1 al 31:");
	if (!Int32.TryParse(Console.ReadLine(), out day))
	{
		Console.WriteLine("El día tiene un formato incorrecto. Recuerda, valores numéricos, del 1 al 31.");
	}
	else if (day < 0 || day > 31)
	{
		Console.WriteLine("Lo siento, el día tiene que ser un valor entre 1 y 31.");
	}
	else{
		break;
	}
} while(true);

Console.WriteLine("¡Ahora a por el mes!");
do {
	Console.WriteLine("Escribe el mes, Valores de 1 al 12.");
	if (!Int32.TryParse(Console.ReadLine(), out month))
	{
		Console.WriteLine("El mes tiene un formato incorrecto. Recuerda, valores numéricos, del 1 al 12.");
	}
	else if (month < 0 || month > 12)
	{
		Console.WriteLine("Lo siento, el mes tiene que ser un valor entre 1 y 12.");
	}
	else{
		break;
	}
} while(true);

Console.WriteLine("¡Y ahora el año!");
do {
	Console.WriteLine("Introduce el año, un valor positivo.");
	if (!Int32.TryParse(Console.ReadLine(), out year))
	{
		Console.WriteLine("El año tiene un formato incorrecto. Recuerda, valores numéricos, valores positivos.");
	}
	else if (year < 0)
	{
		Console.WriteLine("Lo siento, el año tiene que ser un valor positivo.");
	}
	else{
		break;
	}
} while(true);

var service = new DayCalculationService();
var dateTime = DateTime.Parse($"{year}-{month}-{day}", CultureInfo.InvariantCulture);
Console.WriteLine($"El {day}/{month}/{year} será {service.GetDayOfWeek(dateTime)}.");
Console.WriteLine("Pulsa Enter para continuar.");
Console.ReadLine();
