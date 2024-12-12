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
    public partial class frmCadastroCliente : Form
    {
        List<Cliente> clientess;
        public frmCadastroCliente(List<Cliente> clientes)
        {
            InitializeComponent();
            this.clientes = clientes;
        }
    }
}