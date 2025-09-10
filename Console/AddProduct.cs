using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLogic;
using ShopApp;

namespace AddProductClass
{
    internal class addProductClass
    {
        /// <summary>
        /// Добавляет новый товар в корзину через консольный интерфейс
        /// </summary>
        /// <remarks>
        /// Метод запрашивает у пользователя данные о товаре (название, категория, цена, количество, вес),
        /// валидирует введенные значения и добавляет товар в корзину через Logic.AddInBasket()
        /// </remarks>
        public static void AddProduct()
        {
            Console.Clear();
            Console.WriteLine("\n--- Добавление товара ---");

            while (true)
            {
                Console.Write("Название: ");
                string name = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(name))
                {
                    Console.WriteLine("Ошибка: название не может быть пустым! Попробуйте снова.");
                    continue;
                }
                if (!ContainsOnlyLetters(name))
                {
                    Console.WriteLine("Ошибка: название должно содержать только буквы! Попробуйте снова.");
                    continue;
                }

                Console.Write("Категория: ");
                string category = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(category))
                {
                    Console.WriteLine("Ошибка: категория не может быть пустой! Попробуйте снова.");
                    continue;
                }
                if (!ContainsOnlyLetters(category))
                {
                    Console.WriteLine("Ошибка: категория должна содержать только буквы! Попробуйте снова.");
                    continue;
                }

                int price;
                while (true)
                {
                    Console.Write("Цена: ");
                    if (int.TryParse(Console.ReadLine(), out price) && price > 0)
                        break;
                    Console.WriteLine("Ошибка: введите корректную цену (положительное число)! Попробуйте снова.");
                }

                int quantity;
                while (true)
                {
                    Console.Write("Количество: ");
                    if (int.TryParse(Console.ReadLine(), out quantity) && quantity > 0)
                        break;
                    Console.WriteLine("Ошибка: введите корректное количество (положительное число)! Попробуйте снова.");
                }

                int weight;
                while (true)
                {
                    Console.Write("Вес: ");
                    if (int.TryParse(Console.ReadLine(), out weight) && weight > 0)
                        break;
                    Console.WriteLine("Ошибка: введите корректный вес (положительное число)! Попробуйте снова.");
                }

                Logic.AddInBasket(name, category, price, quantity, weight);
                Console.WriteLine("Товар успешно добавлен!");
                Program.WaitForContinue();
                break;
            }
        }

        /// <summary>
        /// Проверяет, содержит ли строка только буквы (включая русские) и пробелы
        /// </summary>
        /// <param name="input">Входная строка для проверки</param>
        /// <returns>True если строка содержит только буквы, иначе False</returns>
        private static bool ContainsOnlyLetters(string input)
        {
            foreach (char c in input)
            {
                // Проверяем что символ - буква (латинская или русская) или пробел
                if (!char.IsLetter(c) && c != ' ')
                {
                    return false;
                }
            }
            return true;
        }
    }
}