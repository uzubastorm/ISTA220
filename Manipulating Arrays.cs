using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manipulating_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] A = { 0, 2, 4, 6, 8, 10 };
            int[] B = { 1, 3, 5, 7, 9 };
            int[] C = { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9, };


            //1st problem

            Console.WriteLine($"the sum of the Arrays are {A.Sum()},{B.Sum()},{C.Sum()}");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            //end of 1st problem



            //2nd problem

            int[] ArrayA = { 0, 2, 4, 6, 8, 10 };
            foreach (int a in ArrayA)
            {
                Console.WriteLine(a);
            }

            Array.Reverse(ArrayA);
            Console.WriteLine("Reserved Array : ");
            foreach (int value in ArrayA)
            {
                Console.WriteLine(value);
            }
            Console.WriteLine("end*****");
            Console.WriteLine();

            int[] ArrayB = { 1, 3, 5, 7, 9 };
            foreach (int a in ArrayB)
            {
                Console.WriteLine(a);
            }

            Array.Reverse(ArrayB);
            Console.WriteLine("Reserved Array : ");
            foreach (int value in ArrayB)
            {
                Console.WriteLine(value);
            }
            Console.WriteLine("end*****");
            Console.WriteLine();

            int[] ArrayC = { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9, };
            foreach (int a in ArrayC)
            {
                Console.WriteLine(a);
            }

            Array.Reverse(ArrayC);
            Console.WriteLine("Reserved Array : ");
            foreach (int value in ArrayC)
            {
                Console.WriteLine(value);
            }
            Console.WriteLine("end*****");

            //end of 2nd problem



            //3rd problem

            Console.WriteLine("\nA: [{0}]", string.Join(", ", A));
            var temp = A[0];
            for (var i = 0; i < A.Length - 1; i++)
            {
                A[i] = A[i + 1];
            }
            A[A.Length - 1] = temp;
            Console.WriteLine("\nAfter rotating array becomes: [{0}]", string.Join(", ", A));


            Console.WriteLine("\nB: [{0}]", string.Join(", ", B));
            var temp2 = B[0];
            for (var i = 0; i < B.Length - 1; i++)
            {
                B[i] = B[i + 1];
            }
            B[B.Length - 1] = temp2;
            Console.WriteLine("\nAfter rotating array becomes: [{0}]", string.Join(", ", B));


             Console.WriteLine("\nC: [{0}]", string.Join(", ", C));
            var temp3 = C[0];
            for (var i = 0; i < C.Length - 1; i++)
            {
                C[i] = C[i + 1];
            }
            C[C.Length - 1] = temp3;
            Console.WriteLine("\nAfter rotating array becomes: [{0}]", string.Join(", ", C));




            //end of 3rd problem



            //4th problem
            /* Console.WriteLine();
              int[] intarray = new int[12] { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9, };
              Array.Sort(intarray);
              foreach (int i in intarray) Console.Write(i + " ");
              Console.WriteLine();*/

            //end of 4th problem
        }
    }
}


    
    

