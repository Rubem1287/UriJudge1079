using System;
using System.Globalization;
namespace Uri1079
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            double m;
            m = 0;
          

            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] vetor = Console.ReadLine().Split(' ');
                double a = double.Parse(vetor[0], CultureInfo.InvariantCulture);
                double b = double.Parse(vetor[1], CultureInfo.InvariantCulture);
                double c = double.Parse(vetor[2], CultureInfo.InvariantCulture);

                m = (double)((a * 2.0) + (b * 3.0) + (c * 5.0)) / (2.0 + 3.0 + 5.0);


                Console.WriteLine(m.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}
