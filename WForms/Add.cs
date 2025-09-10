using ModelLogic;
using System;
using System.Windows.Forms;

namespace WForms
{
    public partial class Add : Form
    {
        /// <summary>
        /// Форма для добавления нового товара в корзину
        /// </summary>
        public Add()
        {
            InitializeComponent();
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
        /// Проверяет, содержит ли строка только буквы и пробелы
        /// </summary>
        /// <param name="input">Входная строка для проверки</param>
        /// <returns>True если строка содержит только буквы и пробелы, иначе False</returns>
        private bool ContainsOnlyLetters(string input)
        {
            foreach (char c in input)
            {
                // Проверяем что символ - буква (латинская или русская) или пробел
                if (!char.IsLetter(c) && c != ' ')
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Обрабатывает нажатие кнопки "Добавить" для валидации и добавления товара
        /// </summary>
        /// <param name="sender">Источник события</param>
        /// <param name="e">Данные события</param>
        private void AddButton_Click(object sender, EventArgs e)
        {
            string name = NametextBox.Text.Trim();
            string category = CategoritextBox.Text.Trim();
            string priceText = PricetextBox.Text.Trim();
            string quantityText = QuantitytextBox.Text.Trim();
            string weightText = WeighttextBox.Text.Trim();

            // Проверка пустых полей
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(category) ||
                string.IsNullOrEmpty(priceText) || string.IsNullOrEmpty(quantityText) ||
                string.IsNullOrEmpty(weightText))
            {
                MessageBox.Show("Заполните все поля", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Проверка что имя содержит только буквы
            if (!ContainsOnlyLetters(name))
            {
                MessageBox.Show("Название должно содержать только буквы и пробелы", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                NametextBox.SelectAll();
                NametextBox.Focus();
                return;
            }

            // Проверка что категория содержит только буквы
            if (!ContainsOnlyLetters(category))
            {
                MessageBox.Show("Категория должна содержать только буквы и пробелы", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CategoritextBox.SelectAll();
                CategoritextBox.Focus();
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

            // Проверка на положительные значения
            if (price <= 0 || quantity <= 0 || weight <= 0)
            {
                MessageBox.Show("Цена, количество и вес должны быть положительными числами", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Добавление товара
            Logic.AddInBasket(name, category, price, quantity, weight);

            MessageBox.Show("Товар добавлен!", "Успех",
                          MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Очистка полей
            NametextBox.Clear();
            CategoritextBox.Clear();
            PricetextBox.Clear();
            QuantitytextBox.Clear();
            WeighttextBox.Clear();
        }
    }
}