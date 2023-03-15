
using ConsoleApp7.Interfaces;
using ConsoleApp7.Services;

StudentService StudentService = new StudentService();


Console.WriteLine("Quit>>> Enter 0: ");
Console.WriteLine("\nCreat>>> Enter 1: ");
Console.WriteLine("\nShow>>> Enter 2: ");
Console.WriteLine("\nId>>> Enter 3: ");
Console.WriteLine("\nDelete>>> Enter 4: ");
Console.WriteLine("\nUpdate>>> Enter 5: ");

Console.WriteLine("\n Make a choice :");
int request = int.Parse(Console.ReadLine());

while (request != 0)
{
    switch (request)
    {
        case 1:
            StudentService.Create();
            break;
        case 2:
            StudentService.Show();
            break;

        case 4:
            StudentService.Delete();
            break;
        case 5:
            StudentService.Update();
            break;

        default:
            Console.WriteLine("Enter only 1, 2, 3, 4 or 5");
            break;
    }

    Console.WriteLine("\nQuit>>> Enter 0: ");
    Console.WriteLine("\nCreat>>> Enter 1: ");
    Console.WriteLine("\nShow>>> Enter 2: ");
    Console.WriteLine("\nId>>> Enter 3: ");
    Console.WriteLine("\nDelete>>> Enter 4: ");
    Console.WriteLine("\nUpdate>>> Enter 5: ");
    request = int.Parse(Console.ReadLine());
}







