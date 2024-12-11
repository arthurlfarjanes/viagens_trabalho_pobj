using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PacotesDeViagens
{
    public partial class frmExibirCliente : Form
    {
        List<Cliente> clientes;
        public frmExibirCliente(List<Cliente> clientes)
        {
            InitializeComponent();
            this.clientes = clientes;
        }
    }
}