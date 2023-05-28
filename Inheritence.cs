using System;
namespace OOPS
{
//Base Class
public class Father
{
public void FatherMethod()
{
Console.WriteLine("this property belong to Father");
}
}
//Derived class
public class Child : Father
{
public void ChildMethod()
{
Console.WriteLine("this property belong to Child");
}
}
}

