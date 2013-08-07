using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

interface User
{
    void show();
}
interface Clerk : User
{
    void add();
}
interface Admin : Clerk
{
    void del();
    void update();
}

interface Schedule
{
    void set();
    void unset();
}

interface Super : Admin, Schedule //multiple inheritance
{

}
class MyApp : Super
{
    public void del()
    {
        Console.WriteLine("Del");
    }

    public void update()
    {
        Console.WriteLine("Update");
    }

    public void add()
    {
        Console.WriteLine("Add");
    }

    public void show()
    {
        Console.WriteLine("Show");
    }

    public void set()
    {
        Console.WriteLine("Set");
    }

    public void unset()
    {
        Console.WriteLine("Unset");
    }
}

class Test
{
    static void Main()
    {
        //Create an object of MyApp
        MyApp app = new MyApp();

        //And "glue" this object reference to User, Admin,Clerk 
        User u = app;
        u.show();

        Admin a = app;
        a.del();
        a.add();

       // doUser(app);  // pass via interface parameter
       // doSuper(app);
    }
    static void doSuper(Super super)
    {
        super.add();
        super.set();
    }
    static void doAdmin(Admin admin)
    {
        admin.del();
    }
    static void doClerk(Clerk c)
    {
        c.add();
    }
    static void doUser(User u)
    {
        u.show();
    }
}