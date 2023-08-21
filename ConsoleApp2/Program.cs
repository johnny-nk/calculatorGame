

using ConsoleApp2;

var menu = new Menu();

var date = DateTime.UtcNow;

string name = GetName();

menu.ShowMenu(name, date);

string GetName()
{
    Console.WriteLine("Please type in your name:");
    var name = Console.ReadLine();
    return name; 
}
 



   
    



