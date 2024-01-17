using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radio
{
    internal class Radio
    {
        public float Volume { get; set; }
        public Radio(float volume)
        {
            Volume = volume;
        }
        public float AlzaVolume()
        {
            Volume+=(float)(Volume*0.1);
            return Volume;
        }
        public float DimunuisciVolume()
        {
            Volume -= (float)(Volume * 0.1);
            return Volume;
        }
    }
}
