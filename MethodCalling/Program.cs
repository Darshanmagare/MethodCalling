using System;

namespace MethodCalling
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            PassByValue obj = new PassByValue();
            obj.ValueParam(20);
            int y = 20;
            obj.PassByref(ref y);
            Console.WriteLine("Outside method" +y);
            int z = 20;
            obj.OutParam(out z);
            Console.WriteLine("Outside method"+z);
        }
    }
}

class PassByValue
{

    public void ValueParam(int a)
    {
        int a = 10; int b = 20;
        int res = a + b;
        Console.WriteLine("Inside Method" + a);
    }

    public void PassByref(ref int b)
    {
        b = 10;
        Console.WriteLine("Inside Method" + b);
    }
    public void OutParam(out int c)
    {
        Console.WriteLine("Inside Method" + a);
    }
}
