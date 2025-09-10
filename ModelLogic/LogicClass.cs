using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLogic
{
    /// <summary>
    /// Предоставляет статические методы для работы с корзиной товаров
    /// </summary>
    public static class Logic
    {
        private static List<Product> products = new List<Product>();

        /// <summary>
        /// Добавляет товар в корзину
        /// </summary>
        /// <param name="name">Название товара</param>
        /// <param name="category">Категория товара</param>
        /// <param name="price">Цена товара</param>
        /// <param name="quantity">Количество товара</param>
        /// <param name="weight">Вес товара</param>
        public static void AddInBasket(string name, string category, int price, int quantity, int weight)
        {
            Product product = new Product()
            {
                Name = name,
                Category = category,
                Price = price,
                Quantity = quantity,
                Weight = weight
            };

            products.Add(product);
        }

        /// <summary>
        /// Удаляет товар из корзины по наименованию
        /// </summary>
        /// <param name="name">Название товара для удаления</param>
        public static void RemoveProduct(string name)
        {
            var product = products.FirstOrDefault(p => p.Name == name);
            if (product != null)
                products.Remove(product);
        }

        /// <summary>
        /// Возвращает товар по наименованию
        /// </summary>
        /// <param name="name">Название товара для поиска</param>
        /// <returns>Найденный товар или null если товар не найден</returns>
        public static List<Product> GetProduct(string name)
        {
            return products.Where(p => p.Name == name).ToList();
        }

        /// <summary>
        /// Обновляет данные существующего товара
        /// </summary>
        /// <param name="name">Название товара для обновления</param>
        /// <param name="category">Новая категория товара</param>
        /// <param name="price">Новая цена товара</param>
        /// <param name="quantity">Новое количество товара</param>
        /// <param name="weight">Новый вес товара</param>
        public static void UpdateProduct(string name, string category, int price, int quantity, int weight)
        {

            if (quantity <= 0)
                throw new ArgumentException("Количество должно быть положительным числом", nameof(quantity));

            if (weight <= 0)
                throw new ArgumentException("Вес должен быть положительным числом", nameof(weight));

            var matchingProducts = products.Where(p => p.Name == name).ToList();

            if (matchingProducts.Count == 0)
            {
                throw new Exception("Товар не найден");
            }

            foreach (var product in matchingProducts)
            {
                product.Category = category;
                product.Price = price;
                product.Quantity = quantity;
                product.Weight = weight;
            }
        }

        /// <summary>
        /// Рассчитывает общую стоимость всех товаров в корзине
        /// </summary>
        /// <returns>Общая стоимость товаров в корзине</returns>
        public static int GetTotalPrice()
        {
            int total = 0;
            foreach (var product in products)
            {
                total += product.Price * product.Quantity;
            }
            return total;
        }

        /// <summary>
        /// Возвращает список товаров указанной категории
        /// </summary>
        /// <param name="category">Категория для поиска товаров</param>
        /// <returns>Список товаров указанной категории</returns>
        public static List<Product> GetProductsByCategory(string category)
        {
            var result = new List<Product>();
            foreach (var product in products)
            {
                if (product.Category == category)
                {
                    result.Add(product);
                }
            }
            return result;
        }

        /// <summary>
        /// Возвращает все товары в корзине
        /// </summary>
        /// <returns>Список всех товаров в корзине</returns>
        public static List<Product> GetAllProducts()
        {
            return products;
        }
    }
}
