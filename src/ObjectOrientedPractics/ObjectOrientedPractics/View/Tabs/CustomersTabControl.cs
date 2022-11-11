using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;
using ObjectOrientedPractics.View.Controls;

namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
    /// Представляет реализацию по представлению покупателей.
    /// </summary>
    public partial class CustomersTabControl : UserControl
    {
        /// <summary>
        /// Коллекция покупателей.
        /// </summary>
        private List<Customer> _customers;

        /// <summary>
        /// Выбранный покупатель.
        /// </summary>
        private Customer _currentCustomer;

        /// <summary>
        /// Создает экземпляр класса <see cref="CustomersTabControl"/>
        /// </summary>
        public CustomersTabControl()
        {
            InitializeComponent();
            _customers = new List<Customer>();
        }

        // <summary>
        /// Возвращает и задает коллекцию покупателей.
        /// </summary>
        public List<Customer> Customers
        {
            get => _customers;
            set
            {
                _customers = value;

                if (_customers != null)
                {
                    UpdateListBox(-1);
                }
            }
        }

        /// <summary>
        /// Обновляет данные в ListBox.
        /// </summary>
        /// <param name="selectedIndex">Выбранный элемент.</param>
        private void UpdateListBox(int selectedIndex)
        {
            CustomersListBox.Items.Clear();
            foreach (Customer customer in _customers)
            {
                CustomersListBox.Items.Add(FormattedText(customer));
            }

            CustomersListBox.SelectedIndex = selectedIndex;
        }

        /// <summary>
        /// Очищает поля вывода информации.
        /// </summary>
        private void ClearCustomersInfo()
        {
            IdTextBox.Clear();
            FullNameTextBox.Clear();
            AddressControl.Clear();
        }

        /// <summary>
        /// Генерирует форматированный текст для отображения.
        /// </summary>
        /// <param name="customer">Товар.</param>
        /// <returns>Возвращает форматированный текст.</returns>
        private string FormattedText(Customer customer)
        {
            return $"{customer.FullName}";
        }

        /// <summary>
        /// Обновляет данные в ListBox.
        /// </summary>
        /// <param name="selectedIndex">Выбранный элемент.</param>
        private void UpdateCustomerInfo(int selectedIndex)
        {
            CustomersListBox.Items.Clear();

            foreach (Customer customer in _customers)
            {
                CustomersListBox.Items.Add($"{customer.FullName}");
            }

            if (selectedIndex == -1) return;

            CustomersListBox.SelectedIndex = selectedIndex;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Customer customer = CustomerFactory.Default();
            _currentCustomer = customer;
            CustomersListBox.Items.Add(FormattedText(_currentCustomer));
            _customers.Add(customer);
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            int index = CustomersListBox.SelectedIndex;

            if (index == -1) return;

            _customers.RemoveAt(index);
            CustomersListBox.Items.RemoveAt(index);

            ClearCustomersInfo();
        }

        private void CustomersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedItem != null)
            {
                int indexSelectedCustomer = CustomersListBox.SelectedIndex;
                _currentCustomer = _customers[indexSelectedCustomer];
                IdTextBox.Text = _currentCustomer.Id.ToString();
                FullNameTextBox.Text = _currentCustomer.FullName;
                AddressControl.Address = _currentCustomer.Address;
            }
        }

        private void FullNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex == -1)
                return;
            try
            {
                string customerCurrentFullName = FullNameTextBox.Text;
                _currentCustomer.FullName = customerCurrentFullName;
                int index = _customers.IndexOf(_currentCustomer);
                UpdateCustomerInfo(index);
            }
            catch
            {
                FullNameTextBox.BackColor = AppColors.ErrorColor;
                return;
            }
            FullNameTextBox.BackColor = AppColors.CorrectColor;
        }
    }
}
