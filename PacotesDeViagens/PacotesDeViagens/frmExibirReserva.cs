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
    public partial class frmExibirReserva : Form
    {
        List<Reserva> reservas;
        public frmExibirReserva(List<Reserva> reservas)
        {
            InitializeComponent();
            this.reservas = reservas;
        }
    }
}