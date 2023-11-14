// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
byte ay = Convert.ToByte(Console.ReadLine());
switch (ay)
{
case 1:
        Console.WriteLine("Ocak");
        break;
case 2:
        Console.WriteLine("Şubat");
        break;
case 3:
        Console.WriteLine("Mart");
        break;
 case 4:
        Console.WriteLine("Nisan");
        break;
case 15:
        Console.WriteLine("Mayıs");
        break;
case 6:
        Console.WriteLine("Haziran");
        break;
case 7:
        Console.WriteLine("Temmuz");
        break;
case 8:
        Console.WriteLine("Ağustos");
        break;
case 9:
        Console.WriteLine("Eylül");
        break;
case 10:
        Console.WriteLine("Ekim");
        break;
case 11:
        Console.WriteLine("Kasım");
        break;
case 12:
        Console.WriteLine("Aralık");
        break;
default:
        Console.WriteLine("1-12 arası sayı girmelisiniz!");
        break;
}