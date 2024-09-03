
using System.Collections.Generic;


using System;
namespace pruebaProgramador
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*Pruebas*/
            Console.WriteLine(CompareThreeNumbers(3, 3, 3));
            Console.WriteLine(isEven(2));
            Console.WriteLine(squared(2));
            Console.WriteLine(isAnagram("Fotolitografía  ", "Litofotografía"));
        }
        /**Comparar tres números:**/
        public static void areEquals(int a, int b, int c)
        {
            if (a == b && a == c)
            {
                Console.WriteLine("Los tres numbero son iguales");
            }
            else if (b == c)
            {
                Console.WriteLine("El segundo y tercer numero son iguales");
            }
            else if (a == b)
            {
                Console.WriteLine("El primer y segundo numero son iguales");
            }
            else if (a == c)
            {
                Console.WriteLine("el primero y tercer numero son iguales");
            }
            else
            {
                Console.WriteLine("Todos los numero son diferentes");
            }
        }
        public static int CompareThreeNumbers(int number1, int number2, int number3)
        {
            areEquals(number1, number2, number3);
            if (number1 > number2 && number1 > number3)
            {
                return number1;
            }
            else if (number2 > number1 && number2 > number3)
            {
                return number2;
            }
            else if (number3 > number1 && number3 > number2)
            {
                return number3;
            }
            else
            {
                return 0;
            }
        }
        /**Función par o impar:**/
        public static bool isEven(int number)
        {
            if (number % 2 == 0)
            {
                return true;
            }
            return false;
        }

        /**Calcular el cuadrado de un número:**/
        public static int squared(int number)
        {
            return (number * number);
        }
        /**Problema de lógica:**/
        public static Dictionary<char, int> fillDictionary(string word)
        {
            word = word.ToLower().Replace(" ", "");
            Console.WriteLine(word);
            Dictionary<char, int> map = new Dictionary<char, int>();
            foreach (char c in word)
            {
                if (!map.ContainsKey(c))
                {
                    map.Add(c, 1);
                }
                else
                {
                    map[c]++;
                }
            }
            return map;
        }

        public static bool isAnagram(string word1, string word2)
        {
            Dictionary<char, int> map = new Dictionary<char, int>();
            Dictionary<char, int> map2 = new Dictionary<char, int>();

            map = fillDictionary(word1);
            map2 = fillDictionary(word2);

            return map.Count == map2.Count && !map.Except(map2).Any();
        }
    }
}

