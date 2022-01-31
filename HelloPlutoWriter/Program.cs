using SharedComponents;
using System;
using System.Reflection;

namespace HelloPlutoWriter
{
    class Program
    {
        static void Main(string[] args)
        {


            MyWriter writer = new MyWriter();


            Console.WriteLine("Hello World!");

            if(writer.IsHelloSunString(Assembly.GetExecutingAssembly().FullName))
            {
                Console.WriteLine(writer.GetHelloSunString());
            }
            else 
            {
                Console.WriteLine(writer.GetHelloGenericWorldString());
            }

        }
    }
}
