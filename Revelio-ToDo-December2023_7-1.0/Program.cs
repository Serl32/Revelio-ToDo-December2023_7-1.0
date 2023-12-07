//Revelio - ToDo Program Version - 1.0

const string version = "1.0";

DateTime dateTime = DateTime.Now;

Console.WriteLine("\tRevelio ToDo Version - {0}\t\t\t{1}", version, dateTime.ToString());

string? inputCommand;

do
{
    inputCommand = Console.ReadLine();
    if (inputCommand == null )
    {
        Console.WriteLine("NULL Command detected.");
        return;
    }

    switch(inputCommand)
    {
        case "add":
            break;
        case "complete":
            break;
        case "create":
            break;
        case "help":
            break;
        default:
            Console.WriteLine("Unknown command detected.");
            Console.WriteLine("Please Enter a valid Command.");
            break;
    }
} while (!inputCommand.Equals("exit"));