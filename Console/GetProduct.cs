using ModelLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopApp;

namespace GetProductClass
{
    internal class getProductClass
    {
        /// <summary>
        /// Выполняет поиск товара по названию и отображает его информацию
        /// </summary>
        /// <remarks>
        /// Метод запрашивает у пользователя название товара, выполняет поиск через Logic.GetProduct()
        /// и отображает подробную информацию о товаре если он найден
        /// </remarks>
        public static void Get()
        {
            Console.Clear();
            Console.WriteLine("\n--- Поиск товара ---");

            
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
                Console.Write("Введите название товара: ");
                string name = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(name))
                {
                    Console.WriteLine("Ошибка: название не может быть пустым! Попробуйте снова.");
                    continue;
                }

                var products = Logic.GetProduct(name); // Это возвращает List<Product>

                if (products != null && products.Count > 0)
                {
                    Console.WriteLine($"\nНайдено товаров: {products.Count}");

                    foreach (var product in products)
                    {
                        Console.WriteLine($"\nНазвание: {product.Name}");
                        Console.WriteLine($"Категория: {product.Category}");
                        Console.WriteLine($"Цена: {product.Price} руб.");
                        Console.WriteLine($"Количество: {product.Quantity}");
                        Console.WriteLine($"Вес: {product.Weight} г");
                        Console.WriteLine("------------------------");
                    }
                }
                else
                {
                    Console.WriteLine("Товар не найден!");
                }

                Program.WaitForContinue();
                break;
            }
        }
    }
}