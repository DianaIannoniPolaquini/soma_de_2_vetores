using System;

namespace SOMA_DE_2_VETORES
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); 
            double [] y = new double[n];
            double [] x = new double[n];

            string[] s = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
            {
                x[i] = double.Parse(s[i]);
            }

            s = Console.ReadLine().Split(' ');
            for (int i = 0;i < n; i++)
            {
                y[i] = double.Parse(s[i]);
            }

            double[] C = new double[n];
            for (int i = 0; i < n; i++)
            {
                C[i] = y[i] + x[i];
                Console.Write(C[i] + " ");
            }
            
        }
    }
}
