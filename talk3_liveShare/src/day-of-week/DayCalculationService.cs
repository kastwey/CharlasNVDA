namespace DayOfWeek;
public class DayCalculationService
{

	public string GetDayOfWeek(DateTime dateTime)
	{
		var daysOfWeek = new string[] { "domingo", "lunes", "martes", "miércoles","jueves","viernes", "sábado", "domingo" };
		return daysOfWeek[(int)dateTime.DayOfWeek];
	}
}