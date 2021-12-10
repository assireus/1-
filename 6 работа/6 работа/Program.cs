using System;

namespace _6_работа
{
    class Program
    {
        static void Main(string[] args)
        {
            ArithmeticProgression arithmeticProgression = new (1,3);
            GeometricProgression geometricProgression = new(6,3);
            Console.WriteLine("Арифметическая прогрессия +3");
            Console.WriteLine("");
            PrintSeries(arithmeticProgression,6);
            arithmeticProgression.Reset();
            Console.WriteLine();
            PrintIIndexable(arithmeticProgression, 3);
            Console.WriteLine();
            Console.WriteLine("Геометрическая прогрессия *3");
            Console.WriteLine();
            PrintSeries(geometricProgression, 6);
            arithmeticProgression.Reset();
            Console.WriteLine();
            PrintIIndexable(geometricProgression, 3);
            print(geometricProgression, 3);

        }
        private static void PrintSeries(ISeries series, int count)
        {
            for (int i = 0; i < count; i++)
            {
                
                Console.WriteLine( series.GetCurrent());
                series.MoveNext();
            }
        }
       private static void PrintIIndexable(IIndexable indexable, int count)
        {
            for (int i = 1; i <= count; i++)
            {

               
                Console.WriteLine(indexable[i]);
             
            }
        }
        private static void print(IIndexable indexable, int count)
        {
            count = 4;
            Console.WriteLine(indexable[count]);

        }
    }
}
