using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLogic;
using ShopApp;

namespace ShowProductsByCategoryClass
{
    internal class showProductsByCategoryClass
    {
        /// <summary>
        /// Отображает товары по указанной категории
        /// </summary>
        /// <remarks>
        /// Метод запрашивает у пользователя категорию, получает товары через Logic.GetProductsByCategory()
        /// и отображает список товаров с их названием, ценой и количеством
        /// </remarks>
        public static void ShowProductsByCategory()
        {
            Console.Clear();
            Console.WriteLine("\n--- Товары по категории ---");

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
                Console.Write("Введите категорию: ");
                string category = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(category))
                {
                    Console.WriteLine("Ошибка: категория не может быть пустой! Попробуйте снова.");
                    continue;
                }

                var products = Logic.GetProductsByCategory(category);

                if (products.Count > 0)
                {
                    Console.WriteLine($"\nТовары в категории '{category}':");
                    foreach (var product in products)
                    {
                        Console.WriteLine($"- {product.Name}: {product.Price} руб. (x{product.Quantity})");
                    }
                }
                else
                {
                    Console.WriteLine("Товары в данной категории не найдены!");
                }

                Program.WaitForContinue();
                break;
            }
        }
    }
}