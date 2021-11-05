using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ingenieria_Software.Mensajes.Tipos
{
    public partial class Conversion : Form
    {
        public Conversion()
        {
            InitializeComponent();
        }

        private void Button_si_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
        }

        private void Button_no_Click(object sender, EventArgs e)
        {
            new Mensajes.Tipos.MotivoDeArchivoMuerto().ShowDialog();
            this.DialogResult = DialogResult.No;
        }

        private void Button_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
