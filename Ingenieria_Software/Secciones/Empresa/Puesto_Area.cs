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
    public partial class Puesto_Area : Form
    {
        public Puesto_Area()
        {
            InitializeComponent();
        }

        private void Puesto_Area_Load(object sender, EventArgs e)
        {
            updateLista();
        }

        private void Button_agregar_Click(object sender, EventArgs e)
        {
            string SQL = String.Format("INSERT INTO `Puesto_Area` (`idArea`, `area`) VALUES ('{0}','{1}')",
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
            ODB.SetCommand("SELECT * FROM `Puesto_Area`");
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
                string SQL = String.Format("DELETE FROM `Puesto_Area` WHERE `area` = '{0}'", item.Text.ToString());
                ODB.NonQuery(SQL);
            }

            textBox_id.Text = "";
            textBox_idioma.Text = "";
            updateLista();
        }

        private void ListView1_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.SelectedItems) { 
             ODB.SetCommand(string.Format("SELECT * FROM `Puesto_Area` WHERE `area` = '{0}'", item.Text.ToString()));
            string[] values = ODB.GetMultiCampos(2);

                textBox_id.Text = values[0];
                textBox_idioma.Text = values[1];
        }
            
        }

        private void Button_actualizar_Click(object sender, EventArgs e)
        {
            

            string SQL = String.Format("UPDATE `Puesto_Area` SET `area`='{0}' WHERE `idArea` = '{1}'", textBox_idioma.Text.ToString(),textBox_id.Text.ToString());
            ODB.NonQuery(SQL);

            updateLista();
        }
    }
}
