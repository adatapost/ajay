using System;
class A
{
    public int a;
 }

class B : A
{
    public  int a;
 }

class Test
{
    static void Main()
    {
        Object x = new A();

        A y = (A) x;
         B z = (B) x;  // -- Invalid cast exception

        A p = x as A;
        B q = x as B;

        Console.WriteLine(p == null);
        Console.WriteLine(q == null);
 
    }
}
