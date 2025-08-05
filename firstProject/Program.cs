

using System.Diagnostics.CodeAnalysis;

Console.WriteLine("enter num of small carpets");
int small = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter num of large carpets");
int large = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("cost of small carpets =$25");
Console.WriteLine("cost of large carpets =$35");
Console.WriteLine("tax is 6%");

int costSmall = small * 25;
int costLarge = large * 35;
int total = costLarge + costSmall;
double tax = 0.06;

Console.Write("your cost without tax : ");
Console.WriteLine(total);

Console.Write("your tax : ");
Console.WriteLine(total * tax);


Console.Write("your cost including tax : ");
Console.WriteLine(total * tax + total);

