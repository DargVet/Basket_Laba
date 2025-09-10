using ModelLogic;
using System;
using System.Windows.Forms;

namespace WForms
{
    public partial class Update : Form
    {
        /// <summary>
        /// Форма для обновления информации о товарах
        /// </summary>
        public Update()
        {
            InitializeComponent();
            LoadProductsToComboBox();
            LoadCategoriesToComboBox();
            ShowAllProducts();
        }

        /// <summary>
        /// Загружает названия товаров в ComboBox
        /// </summary>
        private void LoadProductsToComboBox()
        {
            comboBox1.Items.Clear();
            var products = Logic.GetAllProducts();

            foreach (var product in products)
            {
                if (!comboBox1.Items.Contains(product.Name))
                {
                    comboBox1.Items.Add(product.Name);
                }
            }

            if (comboBox1.Items.Count > 0)
            {
                comboBox1.SelectedIndex = 0;
            }
        }

        /// <summary>
        /// Загружает категории товаров в ComboBox
        /// </summary>
        private void LoadCategoriesToComboBox()
        {
            comboBox2.Items.Clear();
            var products = Logic.GetAllProducts();

            var categories = new System.Collections.Generic.List<string>();
            foreach (var product in products)
            {
                if (!string.IsNullOrEmpty(product.Category) && !categories.Contains(product.Category))
                {
                    categories.Add(product.Category);
                }
            }

            categories.Sort();
            foreach (var category in categories)
            {
                comboBox2.Items.Add(category);
            }

            if (comboBox2.Items.Count > 0)
            {
                comboBox2.SelectedIndex = 0;
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
        /// Обрабатывает нажатие кнопки "Изменить" для обновления данных товара
        /// </summary>
        /// <param name="sender">Источник события</param>
        /// <param name="e">Данные события</param>
        private void Change_Click(object sender, EventArgs e)
        {
            // Получаем выбранные значения из ComboBox
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Выберите товар!", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string name = comboBox1.SelectedItem.ToString();
            string category = comboBox2.SelectedItem?.ToString() ?? "";
            string priceText = textBox3.Text.Trim();
            string quantityText = textBox4.Text.Trim();
            string weightText = textBox5.Text.Trim();

            // Проверка пустых полей
            if (string.IsNullOrEmpty(category) ||
                string.IsNullOrEmpty(priceText) || string.IsNullOrEmpty(quantityText) ||
                string.IsNullOrEmpty(weightText))
            {
                MessageBox.Show("Заполните все поля", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Проверка числовых значений
            if (!int.TryParse(priceText, out int price) ||
                !int.TryParse(quantityText, out int quantity) ||
                !int.TryParse(weightText, out int weight))
            {
                MessageBox.Show("Введите корректные числа в поля Цена, Количество и Вес", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Проверка на существование товара
            var existingProducts = Logic.GetProduct(name);
            if (existingProducts == null || existingProducts.Count == 0)
            {
                MessageBox.Show("Товар с таким названием не найден!", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Обновление товара
            Logic.UpdateProduct(name, category, price, quantity, weight);

            MessageBox.Show("Товар обновлен!", "Успех",
                          MessageBoxButtons.OK, MessageBoxIcon.Information);
            ShowAllProducts();

            // Обновляем списки
            LoadProductsToComboBox();
            LoadCategoriesToComboBox();

            // Очистка числовых полей
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
        }

        /// <summary>
        /// Отображает все товары в списке
        /// </summary>
        private void ShowAllProducts()
        {
            ProductDisplayer.ShowProducts(listBox1);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Автозаполнение категории при выборе товара
            if (comboBox1.SelectedItem != null)
            {
                string selectedName = comboBox1.SelectedItem.ToString();
                var products = Logic.GetProduct(selectedName);

                if (products != null && products.Count > 0)
                {
                    // Устанавливаем категорию первого найденного товара
                    comboBox2.SelectedItem = products[0].Category;
                }
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Можно добавить дополнительную логику при изменении категории
        }
    }
}