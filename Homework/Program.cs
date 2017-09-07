using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            Random rand = new Random();

            int size;
            Console.WriteLine("Введите количество элементов списка: ");
            string sizeAsString = Console.ReadLine();
            bool result = Int32.TryParse(sizeAsString, out size);
            if (!result)
            {
                Console.WriteLine("Attempted conversion of '{0}' failed.",
                                   sizeAsString == null ? "<null>" : sizeAsString);
            }

            int sum = 0;
            for (int i = 0;i<size;i++)
            {
                int number = rand.Next(100);
                numbers.Add(number);
                Console.WriteLine("Элемент {0} = {1}", numbers.IndexOf(number), number);
                if (i % 2 == 0) { sum += number; }
            }
            Console.WriteLine();

            Console.WriteLine("Сумма элементов на четных позициях = {0}", sum);

            int max = numbers.Max();
            int otherMax = numbers[0];
            for(int i = 0; i < size; i++)
            {
                if (numbers[i] == max) { continue; }
                else if (numbers[i] > otherMax)
                {
                    otherMax = numbers[i];
                }
            }
            Console.WriteLine("Второе максимальное число в списке имеет позицию {0} и значение {1}", numbers.IndexOf(otherMax), otherMax);

            Console.ReadLine();
        }
    }
}
