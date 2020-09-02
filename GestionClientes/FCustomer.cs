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
    public partial class FCustomer : Form
    {
        private Customer _editingCustomer;

        public FCustomer()
        {
            InitializeComponent();
        }

        public Customer EditingCustomer
        {
            get { return _editingCustomer; }
            set
            {
                _editingCustomer = value;
                BindSource.Add(_editingCustomer);
            }
        }
    }
}
