//wiem że nie powinno być po Polsku ;P 
int weekDay;
Console.WriteLine("Wprowadź numer dnia tygodnia przedział od 1 do 7");
var enteredDayNumber = Console.ReadLine();
Int32.TryParse(enteredDayNumber, out weekDay);



switch (weekDay){
    case 1:
        WeekDays monday = WeekDays.Poniedziałek;
        Console.WriteLine(monday);
        break;
    case 2:
        WeekDays tuesday = WeekDays.Wtorek;
        Console.WriteLine(tuesday);
        break;
    case 3:
        WeekDays wednesday = WeekDays.Środa;
        Console.WriteLine(wednesday);
        break;
    case 4:
        WeekDays thursday = WeekDays.Czwartek;
        Console.WriteLine(thursday);
        break;
    case 5:
        WeekDays friday = WeekDays.Piątek;
        Console.WriteLine(friday);
        break;
    case 6:
        WeekDays saturday = WeekDays.Sobota;
        Console.WriteLine(saturday);
        break;
    case 7:
        WeekDays sunday = WeekDays.Niedziela;
        Console.WriteLine(sunday);
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
