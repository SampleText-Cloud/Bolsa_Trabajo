using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ingenieria_Software
{
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
        }

        private void ButtonTestBD_Click(object sender, EventArgs e)
        {

            string msg;
            if (ODB.Connection())
            {msg = "CONEXION EXISTOSA";}else{ msg = "FALLO EN CONEXION"; }

            new Mensajes.Tipos.MsgBoxOK(msg).ShowDialog();

            new Secciones.Reclutadores.Administrador().ShowDialog();
        }
    }
}
