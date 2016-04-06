using System;
using System.Linq;
using System.Threading;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            //シャッフルする配列
            var ary = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27 };

            //シャッフルする
            int[] ary2 = ary.OrderBy(i => Guid.NewGuid()).ToArray();

            Console.WriteLine(ary2[0].ToString());
            Thread.Sleep(5000);
        }
    }
}
