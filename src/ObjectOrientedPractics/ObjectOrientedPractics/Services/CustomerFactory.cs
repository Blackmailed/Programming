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
            customer.FullName = "Full name";
            customer.Address = new Address();
            customer.Address.Apartment = "Apartment";
            customer.Address.City = "City";
            customer.Address.Building = "Building";
            customer.Address.Street = "Street";
            customer.Address.Country = "Country";
            customer.Address.Index = 100000;

            return customer;
        }
    }
}
