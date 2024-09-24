using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio95
{
    internal class Aleatorios
    {
        private Random random;

        public Aleatorios()
        {
            random = new Random();
        }

        public int generarRandom(int numBase, int numTope)
        {
            return random.Next(numBase, numTope);
        }

        public int[] generarRandom()
        {
            int numBase = random.Next(0, 100);
            int numTope = random.Next(0, 100);

            if (numBase > numTope)
            {
                int temp = numBase;
                numBase = numTope;
                numTope = temp;
            }

            int size = numTope - numBase;
            int[] array = new int[size];

            int arrayNumBase = numBase;
            for (int i = 0; i <= size - 1; i++)
            {
                array[i] = arrayNumBase;
                arrayNumBase++;
            }

            return array;
        }
    }
}
