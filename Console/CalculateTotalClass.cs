using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLogic;
using ShopApp;

namespace CalculateTotalClass
{
    internal class calculateTotalClass
    {
        /// <summary>
        /// Вычисляет и отображает общую стоимость товаров в корзине
        /// </summary>
        /// <remarks>
        /// Метод очищает консоль, получает общую сумму через Logic.GetTotalPrice()
        /// и отображает результат пользователю
        /// </remarks>
        public static void CalculateTotal()
        {
            Console.Clear();
            int total = Logic.GetTotalPrice();
            Console.WriteLine($"\nОбщая стоимость корзины: {total} руб.");
            Program.WaitForContinue();
        }
    }
}