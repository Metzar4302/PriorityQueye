using System;
using System.Collections.Generic;
using System.Linq;

namespace PriorityQueye
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            List<Human> queye = new List<Human>(){
                new Young(),
                new Middle(),
                new Older()
            };

            short i = 0;
            while (i < 10)
            {
                DeleteFromQueye(queye);
                AddOneEveryone(queye);
                AddNewToQueye(queye, rand);

                i++;
            }
            Console.ReadKey();
        }

        static void DeleteFromQueye(List<Human> queye){
            int maxPrior = queye.Max(x => x.Priority);

            for (int i = 0; i < queye.Count; i++)
            {
                if (queye[i].Priority == maxPrior)
                {
                    System.Console.Write("Deleted: ");
                    Console.ForegroundColor = ConsoleColor.Red; // устанавливаем цвет
                    System.Console.WriteLine($"{queye[i].GetType().Name} {queye[i].Priority}");
                    Console.ResetColor(); // сбрасываем в стандартный
                    
                    queye.Remove(queye[i]);
                    break;
                }
            }
        }

        static void AddNewToQueye(List<Human> queye, Random rand){
            switch (rand.Next(1,4))
            {
                case 1: queye.Add(new Young()); 
                    System.Console.Write($"Added: ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    System.Console.WriteLine($"Young");
                    break;
                case 2: queye.Add(new Middle());
                    System.Console.Write($"Added: ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    System.Console.WriteLine($"Middle");
                    break;
                case 3: queye.Add(new Older());
                    System.Console.Write($"Added: ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    System.Console.WriteLine($"Older");
                    break;
            }
            Console.ResetColor(); // сбрасываем в стандартный
        }

        static void AddOneEveryone(List<Human> queye){
            foreach (Human item in queye)
            {
                item.Priority++;
            }
        } 
    }
}
