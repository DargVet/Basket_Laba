using ModelLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopApp;

namespace RemoveProductClass
{
    internal class removeProductClass
    {
        /// <summary>
        /// Удаляет товар из корзины по названию
        /// </summary>
        /// <remarks>
        /// Метод запрашивает у пользователя название товара, проверяет его существование
        /// через Logic.GetProduct() и удаляет товар через Logic.RemoveProduct()
        /// </remarks>
        public static void Remove()
        {
            Console.Clear();
            Console.WriteLine("\n--- Удаление товара ---");

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
                Console.Write("Введите название товара для удаления: ");
                string name = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(name))
                {
                    Console.WriteLine("Ошибка: название не может быть пустым! Попробуйте снова.");
                    continue;
                }

                // Проверяем существование товара перед удалением
                var product = Logic.GetProduct(name);
                if (product == null || product.Count == 0)
                {
                    Console.WriteLine("Товар не найден!");
                    Console.WriteLine("Нажмите любую клавишу для выхода");
                    Console.ReadKey();
                    break;
                }

                Logic.RemoveProduct(name);
                Console.WriteLine("Товар успешно удален!");
                Program.WaitForContinue();
                break;
            }
        }
    }
}