using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Radio radio=new Radio(70);
            Console.WriteLine(radio.Volume);
            Console.WriteLine(radio.AlzaVolume());
            Console.WriteLine(radio.DimunuisciVolume());
            Console.ReadLine();
        }
    }
}
