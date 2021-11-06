using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ingenieria_Software.Secciones.Empresa
{
    public partial class Perfiles : Form
    {
        public Perfiles()
        {
            InitializeComponent();
            CenterToScreen();
            checkAreas();
            checkTipos();
            checkIdiomas();
        }
        private void checkIdiomas()
        {
            ODB.SetCommand("SELECT * FROM `Idiomas`");
            string[] lista = ODB.GetMultiId();
            foreach (string area in lista)
            {
                if (area != null && area != "")
                {
                    checkedListBox_idiomas.Items.Add(area);
                }
            }
        }
        private void checkTipos()
        {
            ODB.SetCommand("SELECT * FROM `Puesto_Tipo`");
            string[] lista = ODB.GetMultiId();
            foreach (string area in lista)
            {
                if (area != null && area != "")
                {
                    comboBox_puesto.Items.Add(area);
                }
            }
        }

        private void checkAreas()
        {
            ODB.SetCommand("SELECT * FROM `Puesto_Area`");
            string[] lista = ODB.GetMultiId();
            foreach (string area in lista)
            {
                if (area != null && area != "")
                {
                    comboBox_tipo.Items.Add(area);
                }
            }
        }
        private void Button_agregar_Click(object sender, EventArgs e)
        {

        }
    }
}
