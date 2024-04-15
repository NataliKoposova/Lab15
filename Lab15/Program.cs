using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArithProgression arithProgression = new ArithProgression();
            GeomProgression geomProgression = new GeomProgression();
            arithProgression.setStart(3);
            arithProgression.Step = 3;
            Console.WriteLine("Арифметическая прогрессия");
            Console.WriteLine(arithProgression.getNext());
            Console.WriteLine(arithProgression.getNext());
            Console.WriteLine(arithProgression.getNext());
            Console.WriteLine(arithProgression.getNext());
            arithProgression.reset();
            Console.WriteLine(arithProgression.getNext());
            Console.WriteLine(arithProgression.getNext());
            Console.WriteLine("Геометрическая прогрессия");
            geomProgression.setStart(3);
            geomProgression.Step = 3;
            Console.WriteLine(geomProgression.getNext());
            Console.WriteLine(geomProgression.getNext());
            geomProgression.reset();
            Console.WriteLine(geomProgression.getNext());
        }
    }
}
