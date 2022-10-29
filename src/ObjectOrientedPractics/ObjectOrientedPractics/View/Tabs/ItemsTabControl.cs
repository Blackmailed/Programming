using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
    /// Представляет реализацию по представлению товаров.
    /// </summary>
    public partial class ItemsTabControl : UserControl
    {
        /// <summary>
        /// Коллекция товаров.
        /// </summary>
        private List<Item> _items;

        /// <summary>
        /// Выбранный товар.
        /// </summary>
        private Item _currentItem;

        /// <summary>
        /// Создает экземпляр класса <see cref="ItemsTabControl"/>
        /// </summary>
        public ItemsTabControl()
        {
            InitializeComponent();
            _items = new List<Item>();

            var category = Enum.GetValues(typeof(Category));

            foreach (var value in category)
                CategoryComboBox.Items.Add(value);
        }

        /// <summary>
        /// Очищает поля вывода информации.
        /// </summary>
        private void ClearItemsInfo()
        {
            IdTextBox.Clear();
            CostTextBox.Clear();
            NameTextBox.Clear();
            DescriptionTextBox.Clear();
        }

        /// <summary>
        /// Генерирует форматированный текст для отображения.
        /// </summary>
        /// <param name="item">Товар.</param>
        /// <returns>Возвращает форматированный текст.</returns>
        private string FormattedText(Item item)
        {
            return $"{item.Name}";
        }

        /// <summary>
        /// Обновляет данные в ListBox.
        /// </summary>
        /// <param name="selectedIndex">Выбранный элемент.</param>
        private void UpdateItemInfo(int selectedIndex)
        {
            ItemsListBox.Items.Clear();

            foreach (Item item in _items)
            {
                ItemsListBox.Items.Add($"{item.Name}");
            }

            if (selectedIndex == -1) return;

            ItemsListBox.SelectedIndex = selectedIndex;
        }


        private void AddButton_Click(object sender, EventArgs e)
        {
            Item item = ItemFactory.Default();
            _currentItem = item;
            ItemsListBox.Items.Add(FormattedText(_currentItem));
            _items.Add(item);
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            int index = ItemsListBox.SelectedIndex;

            if (index == -1) return;

            _items.RemoveAt(index);
            ItemsListBox.Items.RemoveAt(index);

            ClearItemsInfo();
        }

        private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = ItemsListBox.SelectedIndex;

            if (index == -1) return;

            _currentItem = _items[index];

            IdTextBox.Text = _currentItem.Id.ToString();
            CostTextBox.Text = _currentItem.Cost.ToString();
            NameTextBox.Text = _currentItem.Name;
            DescriptionTextBox.Text = _currentItem.Info;
            CategoryComboBox.SelectedItem = _currentItem.Category;
        }

        private void CostTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex == -1)
                return;
            try
            {
                string itemCurrentCost = CostTextBox.Text;
                int itemCost = int.Parse(itemCurrentCost);
                _currentItem.Cost = itemCost;
                int index = _items.IndexOf(_currentItem);
                UpdateItemInfo(index);
            }
            catch
            {
                CostTextBox.BackColor = AppColors.ErrorColor;
                return;
            }
            CostTextBox.BackColor = AppColors.CorrectColor;
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex == -1)
                return;
            try
            {
                string itemCurrentName = NameTextBox.Text;
                _currentItem.Name = itemCurrentName;
                int index = _items.IndexOf(_currentItem);
                UpdateItemInfo(index);
            }
            catch
            {
                NameTextBox.BackColor = AppColors.ErrorColor;
                return;
            }
            NameTextBox.BackColor = AppColors.CorrectColor;
        }

        private void DescriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex == -1)
                return;
            try
            {
                string itemCurrentDescription = DescriptionTextBox.Text;
                _currentItem.Info = itemCurrentDescription;
                int index = _items.IndexOf(_currentItem);
                UpdateItemInfo(index);
            }
            catch
            {
                DescriptionTextBox.BackColor = AppColors.ErrorColor;
                return;
            }
            DescriptionTextBox.BackColor = AppColors.CorrectColor;
        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedItem == null) return;

            _currentItem.Category = (Category)CategoryComboBox.SelectedItem;
            int index = _items.IndexOf(_currentItem);
            UpdateItemInfo(index);

        }
    }
}
