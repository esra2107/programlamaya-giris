// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

double faizoranı, anapara, gun;
double faiz = 0;
Console.Write("faizoranı giriniz");
faizoranı= Convert.ToDouble(Console.ReadLine());
Console.Write("anapara giriniz");
anapara = Convert.ToDouble(Console.ReadLine());
Console.Write("gun giriniz");
gun = Convert.ToDouble(Console.ReadLine());
faiz = (anapara * faizoranı * gun) / 360;
Console.Write("faiz:" + faiz.ToString());
Console.ReadKey();
