

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


//Console.WriteLine("ENTER TEMP");
//int temp=Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("ENTER WIND SPEED");
//int wind = Convert.ToInt32(Console.ReadLine());

//bool coat = temp < 22 && wind > 25;
//Console.WriteLine("need to wear coat : " + coat);


//Console.Write("enter length= ");
//int l=Convert.ToInt32(Console.ReadLine());
//Console.Write("enter width= ");
//int w = Convert.ToInt32(Console.ReadLine());
//Console.Write("enter height= ");
//int h = Convert.ToInt32(Console.ReadLine());

//int vol = l * w * h;

//if(vol > 0 && vol<= 100)
//{
//    Console.WriteLine("cost = $2.5");
//}

//else if(vol> 100 && vol <= 500)
//{
//    Console.WriteLine("cost =$ " + (2.5+ 2.5 *0.1) );
//}

//else if (vol > 500 && vol <= 1000)
//{
//    Console.WriteLine("cost =$ " + (2.5 + 2.5 * 0.25));
//}
//else
//{
//    Console.WriteLine("invalid");
//}







