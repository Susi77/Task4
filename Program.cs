using System;
using AppleIphonee;
using Xiaomii;
using Nokiaa;

namespace Mobile_Hierarchy
{
    class Program
    {
        static void Main(string[] args)
        { 

            //Apple , Iphone 9

            Console.WriteLine("Apple Iphone ");
            Console.WriteLine("----------------");

            var i = new AppleIphone();
            Console.WriteLine(i.OperationSystem());
            Console.WriteLine(i.Sim());
            Console.WriteLine(i.Camera());
            Console.WriteLine(i.Memory());
            Console.WriteLine();

            Console.WriteLine("Iphone 9");
            Console.WriteLine("----------------");

            var ip = new AppleIphone.Iphone9();
            Console.WriteLine(ip.OperationSystem());
            Console.WriteLine(ip.Sim());
            Console.WriteLine(ip.Camera());
            Console.WriteLine(ip.Memory());
            Console.WriteLine(ip.useRAM());
            Console.WriteLine(ip.UsePrivateMember());

            Console.WriteLine();

            //Nokia , Nokia x6

            Console.WriteLine("Nokia ");
            Console.WriteLine("----------------");

            var n = new Nokia();
            Console.WriteLine(n.OperationSystem());
            Console.WriteLine(n.Sim());
            Console.WriteLine(n.Camera());
            Console.WriteLine(n.Memory());
            Console.WriteLine(n.Chip());
            Console.WriteLine();

            Console.WriteLine("Nokia x6 ");
            Console.WriteLine("----------------");

            var no = new Nokia.NokiaX6();
            Console.WriteLine(no.OperationSystem());
            Console.WriteLine(no.Sim());
            Console.WriteLine(no.Camera());
            Console.WriteLine(no.Memory());
            Console.WriteLine(no.UseProtecedRAM());
            Console.WriteLine(no.Chip());
            Console.WriteLine();

            //Xiaomi ,Xiaomi Note 9s
            Console.WriteLine("Xiaomi ");
            Console.WriteLine("----------------");

            var x = new Xiaomi();
            Console.WriteLine(x.OperationSystem());
            Console.WriteLine(x.Sim());
            Console.WriteLine(x.Camera());
            Console.WriteLine(x.Memory());
            Console.WriteLine(x.Chip());
            Console.WriteLine();

            Console.WriteLine("Xiaomi Note 9s   ");
            Console.WriteLine("----------------");

            var xi = new Xiaomi.XiaomiNote9s();
            Console.WriteLine(xi.OperationSystem());
            Console.WriteLine(xi.Sim());
            Console.WriteLine(xi.Camera());
            Console.WriteLine(xi.Memory());
            Console.WriteLine(xi.useRAM());
            Console.WriteLine(xi.Chip());

            Console.ReadKey();
        }
    }
}
