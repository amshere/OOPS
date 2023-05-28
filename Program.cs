// See https://aka.ms/new-console-template for more information
using OOPS;
using System;
Console.WriteLine("Hello, World!");
Customer obj = new Customer();
//obj.displayData();
//fields calling
Console.WriteLine("Customer=" + obj.CustID);
Console.WriteLine("Name=" + obj.Name);
Console.WriteLine("Address=" + obj.Address);

FunOverLoad obj1 = new FunOverLoad();
obj1.setName("Tom");
Console.WriteLine("Name=" + obj1.name);
obj1.setName("Tom", "Jerry");
Console.WriteLine("Name=" + obj1.name);
obj1.setName("Tom", "Jerry", "Spike");
Console.WriteLine("Name=" + obj1.name);

PartialPart obj2 = new PartialPart();
obj2.displayData1();
obj2.displayData2();

Encapsulation objencaps = new Encapsulation(20);
objencaps.MySquare();

Father objfather = new Father();
objfather.FatherMethod();
//Here Child object can access both class methods
Child objchild = new Child();
objchild.FatherMethod();
objchild.ChildMethod();

//Interface
IShape[] shapes = new IShape[3];
shapes[0] = new Circle(5);
shapes[1] = new Square(4);
shapes[2] = new Triangle(4, 5);
foreach (IShape shape in shapes)
{
shape.Display();
Console.WriteLine("Area: " + shape.CalculateArea());
Console.WriteLine();
}

//Indexer
MyCollection collection = new MyCollection();
collection[0] = "Hello";
string value = collection[0];
Console.WriteLine(value);  // Output: Hello






