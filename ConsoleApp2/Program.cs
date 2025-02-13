using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{      /// <summary>
     /// 2. Создать объекты класса:с использованием конструктора без параметров и присваивания значений полям объекта;с явной инициализацией;с использованием конструктора
     /// с двумя параметрами, введенными с клавиатуры.
     /// </summary>
     class Program
        static void Main(string[] args)
        {
            Calculate calc = new Calculate();
            calculate.material = 5;
            calculate.material2 = 10;
            Console.WriteLine();
            Calculate calculate = new Calculate(4.5, 14.2);
            Console.WriteLine(calculate);
            Console.WriteLine();
        }
    }
}
