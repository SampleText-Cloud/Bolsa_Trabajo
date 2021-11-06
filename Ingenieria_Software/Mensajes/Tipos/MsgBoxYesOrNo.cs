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
    public partial class MsgBoxYesOrNo : Form
    {
        public MsgBoxYesOrNo()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void Button_yes_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
        }

        private void Button_no_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
        }
    }
}
