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
