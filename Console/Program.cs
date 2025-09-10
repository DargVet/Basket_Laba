using System;
using AddProductClass;
using RemoveProductClass;
using GetProductClass;
using UpdateProductClass;
using CalculateTotalClass;
using ShowProductsByCategoryClass;
using ShowAllProductsClass;
using ModelLogic;

namespace ShopApp
{
    class Program
    {
        /// <summary>
        /// Главная точка входа в приложение магазина корзины покупок
        /// </summary>
        /// <param name="args">Аргументы командной строки</param>
        static void Main(string[] args)
        {
            bool exit = false;

            while (!exit)
            {
                ShowMenu();
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        addProductClass.AddProduct();
                        break;
                    case "2":
                        removeProductClass.Remove();
                        break;
                    case "3":
                        getProductClass.Get();
                        break;
                    case "4":
                        updateProductClass.Update();
                        break;
                    case "5":
                        calculateTotalClass.CalculateTotal();
                        break;
                    case "6":
                        showProductsByCategoryClass.ShowProductsByCategory();
                        break;
                    case "7":
                        showAllProductsClass.ShowAllProducts();
                        break;
                    case "0":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Неверный выбор! Попробуйте снова.");
                        WaitForContinue();
                        break;
                }
            }
        }

        /// <summary>
        /// Отображает главное меню приложения
        /// </summary>
        static void ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("=== МАГАЗИН - КОРЗИНА ПОКУПОК ===");
            Console.WriteLine("1. Добавить товар");
            Console.WriteLine("2. Удалить товар");
            Console.WriteLine("3. Найти товар по имени");
            Console.WriteLine("4. Обновить товар");
            Console.WriteLine("5. Посчитать общую сумму");
            Console.WriteLine("6. Показать товары по категории");
            Console.WriteLine("7. Показать все товары");
            Console.WriteLine("0. Выход");
            Console.Write("Выберите действие: ");
        }

        /// <summary>
        /// Ожидает нажатия любой клавиши пользователем для продолжения работы
        /// </summary>
        public static void WaitForContinue()
        {
            Console.WriteLine("\nНажмите любую клавишу для продолжения...");
            Console.ReadKey();
        }
    }
}