using System;
using System.Collections;
class MyCollection : IEnumerable
{
    int[] no = { 11, 22, 33, 44 };
    public IEnumerator GetEnumerator()
    {
        return no.GetEnumerator();
    }
}

class MyCollectionYield : IEnumerable
{
    int[] no = { 11, 22, 33, 44 };
    public IEnumerator GetEnumerator()
    {
        foreach (var t in no)
        {
            yield return t;
        }
    }
}

class MyCollectionInterface : IEnumerable
{
    int[] no = { 11, 22, 33, 44 };
    public IEnumerator GetEnumerator()
    {
        return new MyEnumerator(no);
    }

    private class MyEnumerator : IEnumerator
    {
        int[] no = null;
        int index = -1;
        public MyEnumerator(int[] no) { this.no = no; }
        public object Current
        {
            get { return no[index]; }
        }

        public bool MoveNext()
        {
            index++;
            if (index >= no.Length)
                return false;
            return true;
        }

        public void Reset()
        {
            index = -1;
        }
    }

}
class Test
{
    static IEnumerator SaySomething()
    {
        yield return "Hello";
        yield return "Hi";
    }
    static void Main1()
    {
        MyCollection collection = new MyCollection();
        foreach (var t in collection)
        {
            int n = (int)t;
            Console.WriteLine(n * n);
        }
        MyCollectionYield collectionYield = new MyCollectionYield();
        foreach (var t in collection)
        {
            int n = (int)t;
            Console.WriteLine(n * n);
        }

        MyCollectionInterface collection2 = new MyCollectionInterface();
        foreach (var t in collection2)
        {
            int n = (int)t;
            Console.WriteLine(n * n);
        }
        IEnumerator e = SaySomething();
        while (e.MoveNext())
        {
            Console.WriteLine(e.Current);
        }
    }
}
