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
        /// Обновляет данные в ListBox.
        /// </summary>
        /// <param name="selectedIndex">Выбранный элемент.</param>
        private void UpdateListBox(int selectedIndex)
        {
            ItemsListBox.Items.Clear();
            var orderedListItems = from item in _items
                                   orderby item.Name
                                   select item;

            _items = orderedListItems.ToList();

            foreach (Item item in _items)
            {
                ItemsListBox.Items.Add(FormattedText(item));
            }

            ItemsListBox.SelectedIndex = selectedIndex;
        }

        /// <summary>
        /// Ищет индекс элемента по уникальному идентификатору.
        /// </summary>
        /// <returns>Возвращает индекс найденного элемента.</returns>
        private int FindIndexItemById()
        {
            var orderedListItems = from item in _items
                                   orderby item.Name
                                   select item;

            _items = orderedListItems.ToList();
            int currentItemId = _currentItem.Id;
            int index = -1;

            for (int i = 0; i < _items.Count; i++)
            {
                if (_items[i].Id != currentItemId) continue;

                index = i;
                break;
            }

            return index;
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


        private void AddButton_Click(object sender, EventArgs e)
        {
            Item item = ItemFactory.Randomize();
            _currentItem = item;
            _items.Add(item);
            UpdateListBox(0);
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            int index = ItemsListBox.SelectedIndex;

            if (index == -1) return;

            _items.RemoveAt(index);
            UpdateListBox(-1);

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
        }

        private void CostTextBox_TextChanged(object sender, EventArgs e)
        {
            int index = ItemsListBox.SelectedIndex;

            if (index == -1) return;

            try
            {
                int cost = Convert.ToInt32(CostTextBox.Text);
                _currentItem.Cost = cost;
            }
            catch
            {
                CostTextBox.BackColor = AppColor.ErrorColor;
                return;
            }

            CostTextBox.BackColor = AppColor.CorrectColor;
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            int index = ItemsListBox.SelectedIndex;

            if (index == -1) return;

            try
            {
                string name = NameTextBox.Text;
                _currentItem.Name = name;

                int indexItem = FindIndexItemById();
                UpdateListBox(indexItem);
            }
            catch
            {
                NameTextBox.BackColor = AppColor.ErrorColor;
                return;
            }

            NameTextBox.BackColor = AppColor.CorrectColor;
        }

        private void DescriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            int index = ItemsListBox.SelectedIndex;

            if (index == -1) return;

            try
            {
                string info = DescriptionTextBox.Text;
                _currentItem.Info = info;
            }
            catch
            {
                DescriptionTextBox.BackColor = AppColor.ErrorColor;
                return;
            }

            DescriptionTextBox.BackColor = AppColor.CorrectColor;
        }
    }
}
