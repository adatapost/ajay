using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

interface Printer
{
    void Print();
}
interface Screen
{
    void Print();
}

class Doc : Printer, Screen
{
    public void Print()
    {
        Console.WriteLine("Common -- Printer/Screen");
    }
    void Printer.Print()
    {
        Console.WriteLine("Printer::Print");
    }

    void Screen.Print()
    {
        Console.WriteLine("Screen::Print");
    } 
}

class Test
{
    static void Main()
    {
        Doc c = new Doc();
        c.Print();

        (c as Printer).Print();
        (c as Screen).Print();
        Printer printer = c;
        Screen screen = c;

        printer.Print();
        screen.Print();
    }
}