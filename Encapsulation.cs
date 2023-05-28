using System;
namespace OOPS
{
class Encapsulation
{
/// <summary>
/// Every member Variable and Function of the class are bind
/// with the Encapsulation class object only and safe with
/// the outside inference
/// </summary>
// Encapsulation Begin
int x;
//class constructor
public Encapsulation(int iX)
{
this.x = iX;
}
//calculating the square
public void MySquare()
{
int Calc = x * x;
Console.WriteLine(Calc);
}
// End of Encapsulation
}
}

