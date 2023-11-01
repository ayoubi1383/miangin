using System.Diagnostics.CodeAnalysis;
using System.Reflection.Metadata;
using System.Security.Cryptography;




Console.WriteLine("please enter your score correctly");
Console.WriteLine("fizik:");
double a1 = Convert.ToDouble(Console.ReadLine());
if (a1 >= 0 && a1 <= 20) { }
else { Console.WriteLine("please insert your score between 0 to 20 !"); }


Console.WriteLine("riazi:");
double a2 = Convert.ToDouble(Console.ReadLine());
if (a2 >= 0 && a2 <= 20) { }
else { Console.WriteLine("please insert your score between 0 to 20 !"); }

Console.WriteLine("shimi:");
double a3 = Convert.ToDouble(Console.ReadLine());
if (a3 >= 0 && a3 <= 20) { }
else { Console.WriteLine("please insert your score between 0 to 20 !"); }

Console.WriteLine("arabi:");
double a4 = Convert.ToDouble(Console.ReadLine());
if (a4 >= 0 && a4 <= 20) { }
else { Console.WriteLine("please insert your score between 0 to 20 !"); }

Console.WriteLine("zaban:");
double a5 = Convert.ToDouble(Console.ReadLine());
if (a5 >= 0 && a5 <= 20) { }
else { Console.WriteLine("please insert your score between 0 to 20 !"); }

Console.WriteLine("varzesh:");
double a6 = Convert.ToDouble(Console.ReadLine());
if (a6 >= 0 && a6 <= 20) { }
else { Console.WriteLine("please insert your score between 0 to 20 !"); }

Console.WriteLine("dini:");
double a7 = Convert.ToDouble(Console.ReadLine());
if (a7 >= 0 && a7 <= 20) { }
else { Console.WriteLine("please insert your score between 0 to 20 !"); }

Console.WriteLine("farsi:");
double a8 = Convert.ToDouble(Console.ReadLine());
if (a8 >= 0 && a8 <= 20) { }
else { Console.WriteLine("please insert your score between 0 to 20 !"); }

Console.WriteLine("hesaban:");
double a9 = Convert.ToDouble(Console.ReadLine());
if (a9 >= 0 && a9 <= 20) { }
else { Console.WriteLine("please insert your score between 0 to 20 !"); }

Console.WriteLine("hendese:");
double a10 = Convert.ToDouble(Console.ReadLine());
if (a10 >= 0 && a10 <= 20) { }
else { Console.WriteLine("please insert your score between 0 to 20 !"); }

double sum=(a1 * 4) + (a2 * 3) + (a3 * 3) + (a4 * 2) + (a5 * 2) + (a6 * 1) + (a7 * 2) + (a8 * 2) + (a9 * 3) + (a10 * 3);
double moadel = sum / 25;
Console.Write("your score is:");
Console.Write(moadel);






