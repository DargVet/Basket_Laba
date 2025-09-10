using ModelLogic;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WForms
{
    public partial class AllCategori : Form
    {
        /// <summary>
        /// Форма для отображения товаров по выбранной категории
        /// </summary>
        public AllCategori()
        {
            InitializeComponent();
            LoadCategoriesToComboBox();
        }

        /// <summary>
        /// Загружает уникальные категории товаров в ComboBox
        /// </summary>
        private void LoadCategoriesToComboBox()
        {
            comboBox1.Items.Clear();
            var products = Logic.GetAllProducts();

            // Собираем все уникальные категории
            var categories = new List<string>();
            foreach (var product in products)
            {
                if (!string.IsNullOrEmpty(product.Category) && !categories.Contains(product.Category))
                {
                    categories.Add(product.Category);
                }
            }

            // Сортируем категории и добавляем в ComboBox
            categories.Sort();
            foreach (var category in categories)
            {
                comboBox1.Items.Add(category);
            }

            // Выбираем первый элемент если есть категории
            if (comboBox1.Items.Count > 0)
            {
                comboBox1.SelectedIndex = 0;
            }
        }

        /// <summary>
        /// Обрабатывает нажатие кнопки "Назад" для возврата на главную форму
        /// </summary>
        /// <param name="sender">Источник события</param>
        /// <param name="e">Данные события</param>
        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm form = new MainForm();
            form.Show();
        }

        /// <summary>
        /// Обрабатывает нажатие кнопки "Найти" для поиска и отображения товаров по категории
        /// </summary>
        /// <param name="sender">Источник события</param>
        /// <param name="e">Данные события</param>
        private void Findbutton_Click(object sender, EventArgs e)
        {
            // Получаем выбранную категорию из ComboBox
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Выберите категорию!", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string category = comboBox1.SelectedItem.ToString();

            var foundProducts = Logic.GetProductsByCategory(category);

            if (foundProducts == null || foundProducts.Count == 0)
            {
                MessageBox.Show("Товары в этой категории не найдены!", "Информация",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            listBox1.Items.Clear();
            foreach (var product in foundProducts)
            {
                string productInfo = $"Название: {product.Name}, Категория: {product.Category}, " +
                                   $"Цена: {product.Price}, Количество: {product.Quantity}, " +
                                   $"Вес: {product.Weight}";
                listBox1.Items.Add(productInfo);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}