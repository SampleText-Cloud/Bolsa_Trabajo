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
    public partial class Puesto_Tipo : Form
    {
        public Puesto_Tipo()
        {
            InitializeComponent();
            updateLista();
            checkAreas();
            
        }

       
        private void checkAreas()
        {
            ODB.SetCommand("SELECT * FROM `Puesto_Area`");
            string[] lista = ODB.GetMultiId();
            foreach (string area in lista)
            {
                if (area != null && area != "")
                {
                    comboBox_Tipo.Items.Add(area);
                }
            }
        }
        private void Button_agregar_Click(object sender, EventArgs e)
        {
            string SQL = String.Format("INSERT INTO `Puesto_Tipo`(`idTipo`, `tipo`, `area`) VALUES ('{0}','{1}','{2}')",
                                                                     textBox_id.Text.ToString(),
                                                                     textBox_puest.Text.ToString(),
                                                                     comboBox_Tipo.Text.ToString());



            ODB.NonQuery(SQL);

            updateLista();

            textBox_id.Text = "";
            textBox_puest.Text = "";
            comboBox_Tipo.Text = "";
        }

        private void updateLista()
        {
            listView1.Clear();
            ODB.SetCommand("SELECT * FROM `Puesto_Tipo`");
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
            
                string SQL = String.Format("DELETE FROM `Puesto_Tipo` WHERE `idTipo` = '{0}'", textBox_id.Text.ToString());
                ODB.NonQuery(SQL);
            

            textBox_id.Text = "";
            textBox_puest.Text = "";
            comboBox_Tipo.Text = "";
            updateLista();
        }

        private void Button_actualizar_Click(object sender, EventArgs e)
        {
            string SQL = String.Format("UPDATE `Puesto_Tipo` SET `tipo`='{0}',`area`='{1}' WHERE `idTipo` = '{2}'", 
                                                                                                            textBox_puest.Text.ToString(),
                                                                                                            comboBox_Tipo.SelectedItem.ToString(),
                                                                                                            textBox_id.Text.ToString());
            ODB.NonQuery(SQL);

            updateLista();
        }

        private void ListView1_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                ODB.SetCommand(string.Format("SELECT * FROM `Puesto_Tipo` WHERE `tipo` = '{0}'", item.Text.ToString()));
                string[] values = ODB.GetMultiCampos(3);

                textBox_id.Text = values[0];
                textBox_puest.Text = values[1];
                comboBox_Tipo.Text = values[2];
            }
            updateLista();
        }
    }
}
