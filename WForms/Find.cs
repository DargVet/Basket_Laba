using System;
using System.Windows.Forms;
using ModelLogic;

namespace WForms
{
    public partial class Find : Form
    {
        /// <summary>
        /// Форма для поиска товаров по названию
        /// </summary>
        public Find()
        {
            InitializeComponent();
            LoadProductsToComboBox();
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
                // Добавляем только уникальные названия товаров
                if (!comboBox1.Items.Contains(product.Name))
                {
                    comboBox1.Items.Add(product.Name);
                }
            }

            // Выбираем первый элемент если есть товары
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
        /// Обрабатывает нажатие кнопки "Найти" для поиска товаров по названию
        /// </summary>
        /// <param name="sender">Источник события</param>
        /// <param name="e">Данные события</param>
        private void Findbutton_Click(object sender, EventArgs e)
        {
            // Получаем выбранное название из ComboBox
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Выберите товар для поиска!", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string name = comboBox1.SelectedItem.ToString();

            // Ищем товары по названию (возвращает List<Product>)
            var foundProducts = Logic.GetProduct(name);

            if (foundProducts == null || foundProducts.Count == 0)
            {
                MessageBox.Show("Товары не найдены!", "Информация",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Показываем все найденные товары
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