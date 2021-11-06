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
    public partial class MsgBoxOK : Form
    {
        public MsgBoxOK(string mensaje)
        {
            InitializeComponent();
            msg.Text = mensaje;
            CenterToScreen();
        }

        private void Button_ok_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
