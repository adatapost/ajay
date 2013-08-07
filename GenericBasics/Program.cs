using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Data<T>
{
    public T Item { get; set; }
}
class MyValue<T> where T : struct
{
    public T Item { get; set; }
}
class Person { }
class Emp : Person { }
class Student : Person { }

class Animal { }
class Cat : Animal { }
class Dog : Animal { }
class Learning<T> where T : Person { }
class Training<T> where T : Animal { }

class Friend<T1, T2>
    where T1 : Person
    where T2 : Dog
{
}


class Test
{
    static void Main()
    {
        Learning<Student> l1 = new Learning<Student>();
        //Learning<Dog> l2 = new Learning<Dog>();
        Friend<Emp, Dog> f1 = new Friend<Emp, Dog>();
    }
    static void Main3()
    {
        MyValue<int> s = new MyValue<int>();
        MyValue<bool> b = new MyValue<bool>();
    }
    static void Main2()
    {
        Data<int> no = new Data<int>();
        Data<Data<int>> nnoo = new Data<Data<int>>();
        nnoo.Item = new Data<int>();
        nnoo.Item.Item = 20;
    }
    static void Print<MyType>(MyType value)
    {
        Console.WriteLine(value);
    }
    static void Main1()
    {
        Print<float>(10.10f);
        Print<int>(10);
        Print<string>("Hello");
    }

}