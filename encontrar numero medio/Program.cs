using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encontrar_numero_medio
{
    internal class Program
    {
        public static int[] ArrayNumero1;
        public static int[] ArrayNumero2;
        public static int[] JuntarArreglos;
        public static double NumeroMedio;
        static void Main(string[] args)
        {
            ArrayNumero1 = new int[2] {3,4};
            ArrayNumero2 = new int[2] {1,2};

            Console.WriteLine(FindMedianSortedArrays(ArrayNumero1, ArrayNumero2));

            Console.ReadLine();
        }

        public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            int[] JuntarArreglos = nums1.Concat(nums2).OrderBy(n => n).ToArray();

            int arraylenght = JuntarArreglos.Length;
            for (int i = 0;i < arraylenght; i++)
            {
                if (arraylenght % 2 == 1)
                {
                    NumeroMedio = JuntarArreglos[arraylenght / 2];
                }
                else
                {
                    NumeroMedio = (JuntarArreglos[arraylenght / 2 - 1] + JuntarArreglos[arraylenght / 2]) / 2.0;
                }
            }

            return NumeroMedio;
        }
    }
}
