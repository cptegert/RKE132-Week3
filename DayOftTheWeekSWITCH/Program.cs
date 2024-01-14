//int np = Convert.ToInt32(DateTime.Now.DayOfWeek);
int np = -7;
Console.WriteLine(np);


switch (np)
{
    case 0:
        Console.WriteLine("..0");
        break;
    case 1:
        Console.WriteLine("..1");
        break;
    case 2:
        Console.WriteLine("..2");
        break;
    case 3:
        Console.WriteLine("3");
        break;
    case 4:
        Console.WriteLine("4");
        break;
    case 5:
        Console.WriteLine("5");
        break;
    case 6:
        Console.WriteLine("6");
        break;
    default: Console.WriteLine("Oopsie, Your calendar is broken..");
        break;
        }
Console.WriteLine("Have a nice day!");