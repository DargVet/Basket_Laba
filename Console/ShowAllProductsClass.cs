using ModelLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopApp;

namespace ShowAllProductsClass
{
    internal class showAllProductsClass
    {
        /// <summary>
        /// Отображает все товары в корзине с подробной информацией
        /// </summary>
        /// <remarks>
        /// Метод получает все товары через Logic.GetAllProducts() и отображает их в форматированном виде,
        /// включая расчет общей стоимости для каждого товара (цена × количество)
        /// </remarks>
        public static void ShowAllProducts()
        {
            Console.Clear();
            Console.WriteLine("\n--- Все товары в корзине ---");

            var allProducts = Logic.GetAllProducts();

            if (allProducts.Count == 0)
            {
                Console.WriteLine("Товаров нет!");
                Console.WriteLine("Нажмите любую клавишу для выхода");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine($"Найдено товаров: {allProducts.Count}");
                Console.WriteLine("==========================================");

                foreach (var product in allProducts)
                {
                    Console.WriteLine($"Название: {product.Name}");
                    Console.WriteLine($"Категория: {product.Category}");
                    Console.WriteLine("------------------------------------------");
                }

                Program.WaitForContinue();
            }
        }
    }
}