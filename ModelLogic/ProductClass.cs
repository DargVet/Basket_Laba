using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLogic
{
    /// <summary>
    /// Представляет модель товара/продукта в системе
    /// </summary>
    public class Product
    {
        /// <summary>
        /// Получает или задает наименование товара
        /// </summary>
        /// <value>Строка с названием товара</value>
        public string Name { get; set; }

        /// <summary>
        /// Получает или задает категорию, к которой относится товар
        /// </summary>
        /// <value>Строка с названием категории</value>
        public string Category { get; set; }

        /// <summary>
        /// Получает или задает цену товара в целых единицах валюты
        /// </summary>
        /// <value>Целое число, представляющее цену в рублях</value>
        public int Price { get; set; }

        /// <summary>
        /// Получает или задает количество единиц товара в наличии
        /// </summary>
        /// <value>Целое положительное число</value>
        public int Quantity { get; set; }

        /// <summary>
        /// Получает или задает вес единицы товара в целых единицах измерения
        /// </summary>
        /// <value>Целое положительное число, представляющее вес в граммах</value>
        public int Weight { get; set; }
    }
}