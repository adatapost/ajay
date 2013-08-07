using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

interface Message
{
    void Show(int old, int newValue);
}
class Test
{
    private int _no;
    public Message Changed;

    public int No
    {
        get { return _no; }
        set
        {
            if (Changed != null)
            {
                Changed.Show(_no, value);
            }
            _no = value;
        }
    }
}
class TestMain
{
    static void Main()
    {
        Test test = new Test();
        test.Changed = new MyMessage();
        test.No = 10;
        test.No = 50;
    }
}
class MyMessage : Message
{
    public void Show(int old, int newValue)
    {
        int n = 10;
        System.Int32 no1 = 10;
        Emp emp = new Emp();
           

        Console.WriteLine(old + " value is replaced by " + newValue);
    }
}
class Emp
{
    public void print() { }

}