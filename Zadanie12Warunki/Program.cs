int weekDay;
Console.WriteLine("Wprowadź numer dnia tygodnia przedział od 1 do 7");
var enteredDayNumber = Console.ReadLine();
Int32.TryParse(enteredDayNumber, out weekDay);

switch (weekDay){
    case 1:
        Console.WriteLine(WeekDays.Poniedziałek);
        break;
    case 2:
        Console.WriteLine(WeekDays.Wtorek);
        break;
    case 3:
        Console.WriteLine(WeekDays.Środa);
        break;
    case 4:
        Console.WriteLine(WeekDays.Czwartek);
        break;
    case 5:
        Console.WriteLine(WeekDays.Piątek);
        break;
    case 6:
        Console.WriteLine(WeekDays.Sobota);
        break;
    case 7:
        Console.WriteLine(WeekDays.Niedziela);
        break;
    default:
        Console.WriteLine("Nie pdoałeś poprawnego numeru.");
        break;
}
   

public enum WeekDays
{
    Poniedziałek,
    Wtorek,
    Środa,
    Czwartek,
    Piątek,
    Sobota,
    Niedziela
}
