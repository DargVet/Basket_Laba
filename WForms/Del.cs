using ModelLogic;
using System;
using System.Windows.Forms;

namespace WForms
{
    public partial class Del : Form
    {
        /// <summary>
        /// Форма для удаления товаров из корзины
        /// </summary>
        public Del()
        {
            InitializeComponent();
            LoadProductsToComboBox();
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
                // Добавляем только уникальные названия товаров
                if (!comboBox1.Items.Contains(product.Name))
                {
                    comboBox1.Items.Add(product.Name);
                }
                ShowAllProducts();
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
        /// Обрабатывает нажатие кнопки "Удалить" для удаления выбранного товара
        /// </summary>
        /// <param name="sender">Источник события</param>
        /// <param name="e">Данные события</param>
        private void DelButton_Click(object sender, EventArgs e)
        {
            // Получаем выбранное название из ComboBox
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Выберите товар для удаления!", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string name = comboBox1.SelectedItem.ToString();

            // Проверяем существование товара перед удалением
            var products = Logic.GetProduct(name);
            if (products == null || products.Count == 0)
            {
                MessageBox.Show("Товар не найден!", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Удаляем товар
            Logic.RemoveProduct(name);

            MessageBox.Show("Товар удален!", "Успех",
                          MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Обновляем списки
            LoadProductsToComboBox();
            ShowAllProducts();
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

        }
    }
}