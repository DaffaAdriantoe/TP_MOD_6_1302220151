using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPMODUL6_1302220151
{
    internal class SayaTubeVidio
    {
        private int id;
        private string title;
        private int playCount;

        public SayaTubeVidio(string title)
        {
            this.title = title;
            Random randomId = new Random();
            id = randomId.Next(10000, 99999);
        }

        public void increasePlayCount(int increment)
        {
            playCount += increment;
        }

        public void printVideoDetails()
        {
            Console.WriteLine("ID: " + id + "\n" + "Judul: " + title + "\n" + "Play count: " + playCount + "\n");
        }

    }
}
