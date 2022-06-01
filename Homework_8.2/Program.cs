using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_8._2
{
    class Program
    {
        static double phoneNumber;
        static string UserFIO;
        static void AddDictionary(Dictionary<double, string> dictionary)
        {
            while(true)
            {
                Console.Write("Введите ФИО абонента: ");
                UserFIO = Console.ReadLine();

                if (UserFIO == "")
                {
                    Console.WriteLine($"Количество абонентов в книге: {dictionary.Count}\n");
                    break;
                }

                Console.Write("Введите номер абонента: ");
                phoneNumber = double.Parse(Console.ReadLine());

                dictionary.Add(phoneNumber, UserFIO);

                Console.WriteLine(">>>");
            }
        }

        static void SearchDictionary(Dictionary<double, string> dictionary)
        {
            Console.Write("Введите номер телефона: ");
            phoneNumber = double.Parse(Console.ReadLine());

            if (!dictionary.TryGetValue(phoneNumber, out UserFIO))
            {
                Console.WriteLine("Такого абонента не существует.");
            }
            else
            {
                Console.Write(">>>\0");
                Console.WriteLine(dictionary[phoneNumber]);
            }
        }

        static void Main(string[] args)
        {
            Dictionary<double, string> phoneDictionary = new Dictionary<double, string>();
            Console.WriteLine("Добро пожаловать в телефонну книгу.\n");

            AddDictionary(phoneDictionary);
            SearchDictionary(phoneDictionary);

            Console.ReadKey();
        }
    }
}
