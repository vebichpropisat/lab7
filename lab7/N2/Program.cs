using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N2
{
    class Program
    {
        delegate int Randdel();
        delegate double Arraydelegate(Randdel[] a);
        static int Randomorg()
        {
            return new Random().Next(1, 10);
        }
        static void Main()
        {
            var numarr = new Randdel[5];
            for (int i = 0; i < numarr.Length; i++)
            {
                numarr[i] = Randomorg;
                Randdel randdel = numarr[i];
            }
            Arraydelegate arraydelegate = delegate (Randdel[] a)
            {
                double ser = 0;
                for (int i = 0; i < a.Length; i++)
                {
                    ser += a[i]();
                }
                return ser / numarr.Length;
            };
            for (int i = 0; i < numarr.Length; i++)
            {
                Console.WriteLine(numarr[i]());
            }
            Console.WriteLine("Среднее ариф = {0}", arraydelegate(numarr));
        }
    }
}
