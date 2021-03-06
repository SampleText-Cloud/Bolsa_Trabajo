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
        public Conversion(string yes, string no)
        {
            InitializeComponent();
            button_si.Text = yes;
            button_no.Text = no;
            CenterToScreen();

        }

        private void Button_si_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
        }

        private void Button_no_Click(object sender, EventArgs e)
        {
            if(button_no.Text == "ARCHIVO MUERTO") { new Mensajes.Tipos.MotivoDeArchivoMuerto().ShowDialog(); }
            
            this.DialogResult = DialogResult.No;
        }

        private void Button_cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
