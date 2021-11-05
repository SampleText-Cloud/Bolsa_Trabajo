using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ingenieria_Software.Secciones.Postulantes
{
    public partial class Experiencia : Form
    {
        public Experiencia()
        {
            InitializeComponent();
            CenterToScreen();
          
            new Mensajes.Tipos.MsgBoxOK("Esto aun esta en desarrollo").ShowDialog();
            
        }
    }
}
