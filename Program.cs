using CARS.Classes;
using Microsoft.VisualBasic;
Console.WriteLine("ushbu dastur mashinalar haqida:");
Cars myCar=new Cars("Chevrolet Tahoe",2020,100000m,1000m);
Console.WriteLine(myCar.GetCarInfo());
Console.WriteLine("dastur shunday korinishda ishlaydi");
Console.WriteLine("Mashina markasini kiriting:");
myCar.Model=Console.ReadLine();
Console.WriteLine("Qaysi yili ishlab chiqarilgan:");
myCar.Year=int.Parse(Console.ReadLine());
Console.WriteLine("Narxi:");
myCar.Price=decimal.Parse(Console.ReadLine());
Console.WriteLine("Maksimal tezligi qancha:");
myCar.Speed=decimal.Parse(Console.ReadLine());
Console.WriteLine(myCar.GetCarInfo());
Console.WriteLine("hozirgi kundagi narxi:");
Console.WriteLine(myCar.CalculateDepreciation((2024-myCar.Year)));
Console.WriteLine("sizga qaysi yildagi narxi kerak:");
int year1=int.Parse(Console.ReadLine());
if(year1<myCar.Year)
{
    Console.WriteLine("Mashina bu yilda hali ishlab chiqarilgan");
}
else if(year1>myCar.Year)
{
    int a=year1-myCar.Year;
    Console.WriteLine(myCar.CalculateDepreciation(a));
}
else
{
    Console.WriteLine("Mashina yangi");
}

