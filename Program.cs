using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Edible
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal[] animal = new Animal[2];
            animal[0] = new Tiger();
            animal[1] = new Chicken();
            foreach (Animal item in animal)
            {
                Console.WriteLine(item.MakeSound());
                if (item is Chicken)
                {
                    Edible edible = (Chicken)item;
                    Console.WriteLine(edible.HowToEat());
                }
            }
            Fruit[] fruits = new Fruit[2];
            fruits[0] = new Orange();
            fruits[1] = new Apple();
            foreach (Fruit fruit in fruits)
            {
                Console.WriteLine(fruit.HowToEat());
            }
            Console.ReadLine();
        }
    }
}
