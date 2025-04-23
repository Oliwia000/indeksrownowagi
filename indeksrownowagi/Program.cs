using System;
using System.Linq;

namespace IndeksRownowagi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Indeks Równowagi ");
            Console.WriteLine("Wprowadź liczby całkowite oddzielone spacją:");

            string input = Console.ReadLine();
            int[] nums;

            try
            {
                nums = input.Split(' ').Select(int.Parse).ToArray();
            }
            catch
            {
                Console.WriteLine("Błąd. Wprowadź tylko liczby całkowite oddzielone spacją.");
                return;
            }

            int index = ZnajdzIndeksRownowagi(nums);

            if (index != -1)
            {
                Console.WriteLine($"Indeks równowagi: {index}");
            }
            else
            {
                Console.WriteLine("Nie znaleziono indeksu równowagi.");
            }
        }


        /// <summary>
        /// Znajduje pierwszy indeks równowagi w tablicy liczb całkowitych.
        /// </summary>
        /// <param name="nums">Tablica liczb całkowitych</param>
        /// <returns>Pierwszy indeks równowagi lub -1, jeśli nie istnieje</returns>

        /******************************************************
       nazwa funkcji: ZnajdzIndeksRownowagi
       typ zwracany: int, pierwszy indeks równowagi lub -1 jeśli nie istnieje argument
       informacje: Funkcja znajduje pierwszy indeks równowagi  w tablicy liczb całkowitych.
       autor: Oliwia000
      ******************************************************/

        static int ZnajdzIndeksRownowagi(int[] nums)
        {
            int sumaCalosci = nums.Sum();            // Obliczenie sumy wszystkich elementów w tablicy
            int sumaLewo = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                int sumaPrawo = sumaCalosci - sumaLewo - nums[i];            // Obliczenie sumy elementów po prawej stronie bieżącego indeksu

                if (sumaLewo == sumaPrawo)                   // Dodanie bieżącego elementu do sumy po lewej stronie 
                    return i;

                sumaLewo += nums[i];                        // Dodanie bieżącego elementu do sumy po lewej stronie
            }
            return -1;
        }
    }
}
