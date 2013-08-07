using System;

class Test
{
    static void TestArrayRank(Array array)
    {
        
        if (array.Rank == 1)
        {
            foreach (var n in array)
            {
                Console.WriteLine(n);
            }
        }
    }
    static void Main()
    {
        string[] cities =
        {
            "Meh",
            "Patan",
            "Ahm",
            "Surat",
            "Vis"
        };

        Array.Sort(cities);
        
        foreach (var city in cities)
            Console.WriteLine(city);
    }
    static void Main1()
    {
        int[] nos = new int[5];
        int[,] mat = new int[4, 5];
        int[, ,] test = new int[5, 8, 9];

        TestArrayRank(nos);

        string str = "Hello";
        foreach (var t in str)
            Console.WriteLine(t);

        foreach (var t in mat)
            Console.WriteLine(t);

        for (int i = mat.GetLowerBound(0); i <= mat.GetUpperBound(0); i++)
        {
            for (int j = 0; j <= mat.GetUpperBound(1); j++)
            {
                Console.Write("  " + mat[i, j]);
            }
            Console.WriteLine();
        }

        MyCollection c = new MyCollection();
        foreach (var k in c)
            Console.WriteLine(k);
        
    }
}

class MyCollection : System.Collections.ICollection
{
    int[] ar = new int[4];
    public void CopyTo(Array array, int index)
    {
        throw new NotImplementedException();
    }

    public int Count
    {
        get { return ar.Length; }
    }

    public bool IsSynchronized
    {
        get { throw new NotImplementedException(); }
    }

    public object SyncRoot
    {
        get { throw new NotImplementedException(); }
    }

    public System.Collections.IEnumerator GetEnumerator()
    {
        return new MyEnum(ar);
    }
    class MyEnum : System.Collections.IEnumerator
    {
        Array ar;
        int i = -1;
        public MyEnum(Array ar)
        {
            this.ar = ar;
        }
        public object Current
        {
            get { return ar.GetValue(i); }
        }

        public bool MoveNext()
        {
            i++;
            return i<ar.Length ;
            
        }

        public void Reset()
        {
            i = -1;
        }
    }
}