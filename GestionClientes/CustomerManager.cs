using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionClientes
{
    public class CustomerManager
    {
        public List<Customer> _Customers;


        /// <summary>
        /// Consturctor inicializando la coleccion (lista) de tipo customer
        /// </summary>
        public CustomerManager()
        {
            _Customers = new List<Customer>();
        }

        /// <summary>
        /// para el acceso a la lista de clientes (por medio de get
        /// no le ponemos set, solo se permitira manipular la lista desde dentro
        /// </summary>
        public List<Customer> Customers
        {
            get { return _Customers; }
        }

        /// <summary>
        /// para crear un nuevo customer
        /// </summary>
        /// <param name="name"></param>
        /// <param name="lastname"></param>
        /// <param name="address"></param>
        public void AddCustomer(string name, string lastname, string address)
        {
            Customer newCustomer = new Customer()
            {
                Name = name,
                LastName = lastname,
                Address = address
            };
            _Customers.Add(newCustomer);
        }

        public void SetCustomer(int selectedIndex, Customer editingCustomer)
        {
            _Customers[selectedIndex] = new Customer()
            {
                Name = editingCustomer.Name,
                LastName = editingCustomer.LastName,
                Address = editingCustomer.Address
            };
        }

        public void DeleteCustomer(int selectedIndex)
        {
            _Customers.RemoveAt(selectedIndex);
        }

        internal void DuplicateCustomer(int selectedIndex)
        {
            Customer customer = _Customers[selectedIndex];
            AddCustomer("Copia de " + customer.Name, customer.LastName, customer.Address);
        }
    }
}
