using ModelLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopApp;

namespace UpdateProductClass
{
    internal class updateProductClass
    {
        /// <summary>
        /// Обновляет информацию о существующем товаре
        /// </summary>
        /// <remarks>
        /// Метод запрашивает название товара для поиска, затем позволяет пользователю
        /// обновить категорию, цену, количество и вес товара через консольный интерфейс
        /// </remarks>
        public static void Update()
        {
            Console.Clear();
            Console.WriteLine("\n--- Обновление товара ---");

            // Сначала проверяем есть ли вообще товары
            var allProducts = Logic.GetAllProducts();
            if (allProducts == null || allProducts.Count == 0)
            {
                Console.WriteLine("Товаров нет!");
                Console.WriteLine("Нажмите любую клавишу для выхода");
                Console.ReadKey();
                return;
            }

            ShowAllProductsClass.showAllProductsClass.ShowAllProducts();

            while (true)
            {
                Console.Write("Введите название товара для обновления: ");
                string name = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(name))
                {
                    Console.WriteLine("Ошибка: название не может быть пустым! Попробуйте снова.");
                    continue;
                }

                var products = Logic.GetProduct(name);
                if (products == null || products.Count == 0)
                {
                    Console.WriteLine("Товар не найден! Попробуйте снова.");
                    continue;
                }

                Console.WriteLine($"\nНайдено товаров: {products.Count}");

                // Запрашиваем новые данные для всех товаров
                Console.Write("Новая категория: ");
                string category = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(category))
                {
                    Console.WriteLine("Ошибка: категория не может быть пустой! Попробуйте снова.");
                    continue;
                }

                int price;
                while (true)
                {
                    Console.Write("Новая цена: ");
                    if (int.TryParse(Console.ReadLine(), out price) && price > 0)
                        break;
                    Console.WriteLine("Ошибка: введите корректную цену (положительное число)! Попробуйте снова.");
                }

                int quantity;
                while (true)
                {
                    Console.Write("Новое количество: ");
                    if (int.TryParse(Console.ReadLine(), out quantity) && quantity > 0)
                        break;
                    Console.WriteLine("Ошибка: введите корректное количество (положительное число)! Попробуйте снова.");
                }

                int weight;
                while (true)
                {
                    Console.Write("Новый вес: ");
                    if (int.TryParse(Console.ReadLine(), out weight) && weight > 0)
                        break;
                    Console.WriteLine("Ошибка: введите корректный вес (положительное число)! Попробуйте снова.");
                }

                // Обновляем все найденные товары
                foreach (var product in products)
                {
                    Logic.UpdateProduct(product.Name, category, price, quantity, weight);
                }

                Console.WriteLine($"Все товары с названием '{name}' успешно обновлены!");
                Program.WaitForContinue();
                break;
            }
        }
    }
}