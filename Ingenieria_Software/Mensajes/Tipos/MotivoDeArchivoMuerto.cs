using Ingenieria_Software.Secciones.Reclutadores;
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
    public partial class MotivoDeArchivoMuerto : Form
    {
        public MotivoDeArchivoMuerto()
        {
            InitializeComponent();
        }

        private void Button_ok_Click(object sender, EventArgs e)
        {
            Administrador.motivo = richTextBox_motivo.Text.ToString();
            this.DialogResult = DialogResult.OK;
        }
    }
}
