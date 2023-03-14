
using ConsoleApp7.Interfaces;
using ConsoleApp7.Services;

StudentService StudentService = new StudentService();


Console.WriteLine("Quit>>> Enter 0: ");
Console.WriteLine("Creat>>> Enter 1: ");
Console.WriteLine("Show>>> Enter 2: ");
Console.WriteLine("Id>>> Enter 3: ");

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
        case 3:
            StudentService.GetById();
            break;

        default:
            Console.WriteLine("Enter only 1, 2 or 3");
            break;
    }

    Console.WriteLine("Quit>>> Enter 0: ");
    Console.WriteLine("Creat>>> Enter 1: ");
    Console.WriteLine("Show>>> Enter 2: ");
    Console.WriteLine("Id>>> Enter 3: ");
    request = int.Parse(Console.ReadLine());
}







