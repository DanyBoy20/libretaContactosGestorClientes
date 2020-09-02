using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionClientes
{
    public partial class FMain : Form
    {
        /// <summary>
        /// añadimos una isntancia a nuestro customermanager
        /// </summary>
        private CustomerManager _customerManager;

        public FMain()
        {
            InitializeComponent();
            Init(); // inicialiamos nuestra lista de customers
        }

        private void FMain_Activated(object sender, EventArgs e)
        {
            BtnRefresh.PerformClick();
        }

        private void Init()
        {
            _customerManager = new CustomerManager();
            _customerManager.AddCustomer("Pepito", "Martinez", "C/Oxford 24 Int 5");            
        }

        private void EditCustomer()
        {
            if (LstCustomers.SelectedIndices.Count == 0)
                return;

            int selectedIndex = LstCustomers.SelectedIndices[0];
            Customer customer = _customerManager.Customers[selectedIndex];

            FCustomer formCustomer = new FCustomer();
            formCustomer.EditingCustomer = new Customer()
            {
                Name = customer.Name,
                LastName = customer.LastName,
                Address = customer.Address
            };

            if(formCustomer.ShowDialog() == DialogResult.OK)
            {
                _customerManager.SetCustomer(selectedIndex, formCustomer.EditingCustomer);
                BtnRefresh.PerformClick();
            }

            
        }

        private void DeleteCustomer()
        {
            if (LstCustomers.SelectedIndices.Count == 0)
                return;
            int selectedIndex = LstCustomers.SelectedIndices[0];

            _customerManager.DeleteCustomer(selectedIndex);
            BtnRefresh.PerformClick();
        }

        private void DuplicateCustomer()
        {
            if (LstCustomers.SelectedIndices.Count == 0)
                return;
            int selectedIndex = LstCustomers.SelectedIndices[0];

            _customerManager.DuplicateCustomer(selectedIndex);
            BtnRefresh.PerformClick();
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            // cada vez que presionamos el boton, limpiamos el listview y volvemos acargar elementos
            LstCustomers.Items.Clear(); 
            List<Customer> customers = _customerManager.Customers;

            foreach(Customer customer in customers)
            { 
                // creamos el elemento listviewitem para visualizar las columnas
                // añadimos el item (primera columna) y los sbitems (las demas columnas)
                ListViewItem item = LstCustomers.Items.Add(customer.Name);
                item.SubItems.Add(customer.LastName);
                item.SubItems.Add(customer.Address);
                item.SubItems.Add(customer.CreateDate.ToString("dd/MM/yy"));
            }

            if(LstCustomers.Items.Count > 0)
            {
                LstCustomers.Items[0].Selected = true;
            }

            // LblTotalCustomers.Text = "Total de clientes " + LstCustomers.Items.Count;
            LblTotalCustomers.Text = "Total de clientes " + _customerManager.Customers.Count;
            LstCustomers.Focus();
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            FCustomer formCustomer = new FCustomer();
            formCustomer.EditingCustomer = new Customer();

            if(formCustomer.ShowDialog() == DialogResult.OK)
            {
                Customer newCustomer = formCustomer.EditingCustomer;
                _customerManager.AddCustomer(newCustomer.Name, newCustomer.LastName, newCustomer.Address);
                BtnRefresh.PerformClick();
            }
        }

        private void LstCustomers_DoubleClick(object sender, EventArgs e)
        {
            EditCustomer();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            EditCustomer();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DeleteCustomer();
        }

        private void BtnDuplicate_Click(object sender, EventArgs e)
        {
            DuplicateCustomer();
        }
    }
}
