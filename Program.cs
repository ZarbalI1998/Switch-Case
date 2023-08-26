

#region Score else-if
int score = 63;
if (score >= 88 && score <= 100)
{
    Console.WriteLine("Success AA");
}
else if (score >= 81 && score <= 88)
{
    Console.WriteLine("Success BA");
}
else if (score >= 74 && score <= 81)
{
    Console.WriteLine("Success BB");
}
else if (score >= 67 && score <= 74)
{
    Console.WriteLine("Success CB");
}
else if (score >= 60 && score <= 67)
{
    Console.WriteLine("Success CC");
}
else if (score >= 0 && score <= 60)
{
    Console.WriteLine("Success Fall FF");
}


#endregion

#region Switch command

string command = "fly";

switch (command)
{
    case "start":
        Console.WriteLine("Game is starting");
        break;
    case "stop":
        Console.WriteLine("Game stopped");
        break ;
    case "wait":
        Console.WriteLine("Game paused");
        break;
        default:
        Console.WriteLine("Command not found");
        break;
    
}


#endregion
