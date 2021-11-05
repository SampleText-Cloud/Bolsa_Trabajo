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
    public partial class Nacionalidades : Form
    {
        public Nacionalidades()
        {
            InitializeComponent();
            CenterToScreen();
            updateLista();
        }

        private void Button_agregar_Click(object sender, EventArgs e)
        {
            string SQL = String.Format("INSERT INTO `Nacionalidad`(`idNacionalidad`, `nacionalidad`) VALUES ('{0}','{1}')",
                                                                     textBox_id.Text.ToString(),
                                                                     textBox_idioma.Text.ToString());



            ODB.NonQuery(SQL);

            updateLista();

            textBox_id.Text = "";
            textBox_idioma.Text = "";
        }

        private void updateLista()
        {
            listView1.Clear();
            ODB.SetCommand("SELECT * FROM `Nacionalidad`");
            string[] areas = ODB.GetMultiId();

            foreach (string area in areas)
            {
                if (area != null && area != "")
                {
                    listView1.Items.Add(area);
                }
            }
        }

        private void Button_eliminar_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                string SQL = String.Format("DELETE FROM `Nacionalidad` WHERE `nacionalidad` = '{0}'", item.Text.ToString());
                ODB.NonQuery(SQL);
            }

            textBox_id.Text = "";
            textBox_idioma.Text = "";
            updateLista();
        }

        private void Button_actualizar_Click(object sender, EventArgs e)
        {

            string SQL = String.Format("UPDATE `Nacionalidad` SET `nacionalidad`='{0}' WHERE `idNacionalidad` = '{1}'", textBox_idioma.Text.ToString(), textBox_id.Text.ToString());
            ODB.NonQuery(SQL);

            updateLista();
        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ListView1_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                ODB.SetCommand(string.Format("SELECT * FROM `Nacionalidad` WHERE `nacionalidad` = '{0}'", item.Text.ToString()));
                string[] values = ODB.GetMultiCampos(2);

                textBox_id.Text = values[0];
                textBox_idioma.Text = values[1];
            }
        }
    }
}
