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

            try
            {
                this.title = title;

                if (title == null)
                {
                    throw new ArgumentOutOfRangeException();
                }

                if (title.Length > 100)
                {
                    throw new ArgumentOutOfRangeException();
                }
            }

            catch (ArgumentNullException n_exc)
            {
                Console.WriteLine(n_exc.Message);
            }

            catch (ArgumentOutOfRangeException ofvexc)
            {
                Console.WriteLine(ofvexc.Message);
            }
        }

        public void increasePlayCount(int increment)
        {
            try
            {
                checked
                {
                    playCount += increment;
                    if (playCount + increment > 10000000) throw new ArgumentOutOfRangeException();
                }
            }

            catch (ArgumentOutOfRangeException argex)
            {
                Console.WriteLine(argex.Message);
            }

            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void printVideoDetails()
        {
            Console.WriteLine("ID: " + id + "\n" + "Judul: " + title + "\n" + "Play count: " + playCount + "\n");
        }

    }
}
