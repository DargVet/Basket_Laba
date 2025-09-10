using ModelLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WForms
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Главная форма приложения магазина
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            ShowAllProducts();
        }

        /// <summary>
        /// Обрабатывает нажатие кнопки "Добавить" для перехода к форме добавления товара
        /// </summary>
        /// <param name="sender">Источник события</param>
        /// <param name="e">Данные события</param>
        private void Addbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add add = new Add();
            add.Show();
        }

        /// <summary>
        /// Обрабатывает нажатие кнопки "Удалить" для перехода к форме удаления товара
        /// </summary>
        /// <param name="sender">Источник события</param>
        /// <param name="e">Данные события</param>
        private void Delbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Del del = new Del();
            del.Show();
        }

        /// <summary>
        /// Обрабатывает нажатие кнопки "Найти" для перехода к форме поиска товара
        /// </summary>
        /// <param name="sender">Источник события</param>
        /// <param name="e">Данные события</param>
        private void Findbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Find find = new Find();
            find.Show();
        }

        /// <summary>
        /// Обрабатывает нажатие кнопки "Обновить" для перехода к форме обновления товара
        /// </summary>
        /// <param name="sender">Источник события</param>
        /// <param name="e">Данные события</param>
        private void Updatebutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Update update = new Update();
            update.Show();
        }

        /// <summary>
        /// Обрабатывает нажатие кнопки "Общая сумма" для расчета и отображения стоимости корзины
        /// </summary>
        /// <param name="sender">Источник события</param>
        /// <param name="e">Данные события</param>
        private void GetPricebutton_Click(object sender, EventArgs e)
        {
            int total = Logic.GetTotalPrice();
            MessageBox.Show($"Общая сумма корзины: {total} руб.");
        }

        /// <summary>
        /// Обрабатывает нажатие кнопки "Все категории" для перехода к форме поиска по категориям
        /// </summary>
        /// <param name="sender">Источник события</param>
        /// <param name="e">Данные события</param>
        private void AllCategoributton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AllCategori all = new AllCategori();
            all.Show();
        }

        /// <summary>
        /// Отображает все товары в списке на главной форме
        /// </summary>
        private void ShowAllProducts()
        {
            ProductDisplayer.ShowProducts(listBox1);
        }

        /// <summary>
        /// Обрабатывает нажатие кнопки "Выход" для закрытия приложения
        /// </summary>
        /// <param name="sender">Источник события</param>
        /// <param name="e">Данные события</param>
        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}