using ModelLogic;
using System.Windows.Forms;

/// <summary>
/// Статический класс для отображения товаров в элементах управления ListBox
/// </summary>
public static class ProductDisplayer
{
    /// <summary>
    /// Отображает все товары в указанном ListBox
    /// </summary>
    /// <param name="listBox">Элемент управления ListBox для отображения товаров</param>
    public static void ShowProducts(ListBox listBox)
    {
        listBox.Items.Clear();
        var products = Logic.GetAllProducts();

        foreach (var product in products)
        {
            string productInfo = $"Название: {product.Name}, Категория: {product.Category}, " +
                               $"Цена: {product.Price}, Количество: {product.Quantity}, " +
                               $"Вес: {product.Weight}";
            listBox.Items.Add(productInfo);
        }
    }
}