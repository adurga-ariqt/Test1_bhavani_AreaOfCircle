// See https://aka.ms/new-console-template for more information
using Test1_bhavani_AreaOfCircle;

Console.WriteLine("Hello, World!");
Circle obj = new Circle();
Console.WriteLine("enter radius:");
obj.Radius = Convert.ToInt32(Console.ReadLine());
obj.GerCircleAndPerimeter();

