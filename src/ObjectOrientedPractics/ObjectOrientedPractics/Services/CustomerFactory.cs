using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.Services
{
    public static class CustomerFactory
    {
        /// <summary>
        /// Создает покупателя.
        /// </summary>
        /// <returns>Возвращает объект Customer</returns>
        public static Customer Default()
        {
            Customer customer = new Customer();
            customer.FullName = "Full Name";
            customer.Address = "Address";

            return customer;
        }
    }
}
