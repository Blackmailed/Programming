using System;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Services;
using System.Windows.Forms;

namespace ObjectOrientedPractics.View.Controls
{
    public partial class AddressControl : UserControl
    {
        private Address _address;

        public AddressControl()
        {
            _address = new Address();
            InitializeComponent();
        }

        public Address Address
        {
            get
            {
                return _address;
            }
            set
            {
                _address = value;
                SetValuesTextBoxes();
            }
        }
        private void SetValuesTextBoxes()
        {
            PostIndexTextBox.Text = _address.Index.ToString();
            CountryTextBox.Text = _address.Country;
            CityTextBox.Text = _address.City;
            StreetTextBox.Text = _address.Street;
            BuildingTextBox.Text = _address.Building;
            ApartmentTextBox.Text = _address.Apartment;
        }

        private void PostIndexTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int index = Convert.ToInt32(PostIndexTextBox.Text);
                _address.Index = index;
            }
            catch
            {
                PostIndexTextBox.BackColor = AppColors.ErrorColor;
                return;
            }

            PostIndexTextBox.BackColor = AppColors.CorrectColor;
        }

        private void CountryTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _address.Country = CountryTextBox.Text;
            }
            catch
            {
                CountryTextBox.BackColor = AppColors.ErrorColor;
                return;
            }

            CountryTextBox.BackColor = AppColors.CorrectColor;
        }

        private void StreetTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _address.Street = StreetTextBox.Text;
            }
            catch
            {
                StreetTextBox.BackColor = AppColors.ErrorColor;
                return;
            }

            StreetTextBox.BackColor = AppColors.CorrectColor;
        }

        private void CityTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _address.City = CityTextBox.Text;
            }
            catch
            {
                CityTextBox.BackColor = AppColors.ErrorColor;
                return;
            }

            CityTextBox.BackColor = AppColors.CorrectColor;
        }

        private void BuildingTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                _address.Building = BuildingTextBox.Text;
            }
            catch
            {
                BuildingTextBox.BackColor = AppColors.ErrorColor;
                return;
            }

            BuildingTextBox.BackColor = AppColors.CorrectColor;
        }

        private void ApartmentTextBox_TextChanged(object sender, EventArgs e)
        {

            try
            {
                _address.Apartment = ApartmentTextBox.Text;
            }
            catch
            {
                ApartmentTextBox.BackColor = AppColors.ErrorColor;
                return;
            }

            ApartmentTextBox.BackColor = AppColors.CorrectColor;
        }

        public void Clear()
        {
            PostIndexTextBox.Clear();
            CountryTextBox.Clear();
            CityTextBox.Clear();
            StreetTextBox.Clear();
            BuildingTextBox.Clear();
            ApartmentTextBox.Clear();

            PostIndexTextBox.BackColor = AppColors.CorrectColor;
        }
    }
}
