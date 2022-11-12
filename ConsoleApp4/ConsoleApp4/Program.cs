
using ConsoleApp4;

var food1 = new food();
Console.WriteLine("Food Name: ");
food1.FoodName = Console.ReadLine();
Console.WriteLine("Price: ");
food1.Price = int.Parse(Console.ReadLine());
food1.ShowData();

