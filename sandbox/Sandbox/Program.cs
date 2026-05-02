using System;

class Program
{
    static int AddNumbers(int n1, int n2,, int n3)
    {
        int total = n1 + n2 + n3;
    }
    static void Main(string[] args)
    {
        List<int> myData = new List<int>();
        myData.Add(1);
        myData.Add(2);
        myData.Add(3);
        myData.Add(4);
        myData.Add(5);
        myData.Add(99);
        myData.Add(-100);
        
        foreach (int i in myData)
        {
            Console.WriteLine(i);
        }
    }

}