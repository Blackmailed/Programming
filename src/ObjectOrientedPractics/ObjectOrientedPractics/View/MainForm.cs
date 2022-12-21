using System.Windows.Forms;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.View.Tabs;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics
{
    /// <summary>
    /// Предоставляет реализацию расположения элементов на форме.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Покупатели и товары.
        /// </summary>
        private Store _store;

        /// <summary>
        /// Создает экземпляр класса <see cref="MainForm"/>
        /// </summary>
            
        public MainForm()
        {
            InitializeComponent();
            Store _store = new Store();
            ItemsTabControl.Items = _store.Items;
            CustomersTabControl.Customers = _store.Customers;
        }
    }
}
