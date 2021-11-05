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
    public partial class Horarios : Form
    {
        public Horarios()
        {
            InitializeComponent();
            CenterToScreen();
            updateLista();
        }

        private void updateLista()
        {
            listView1.Clear();
            ODB.SetCommand("SELECT * FROM `Horario`");
            string[] areas = ODB.GetMultiId();

            foreach (string area in areas)
            {
                if (area != null && area != "")
                {
                    listView1.Items.Add(area);
                }
            }
        }

        private void Horarios_Load(object sender, EventArgs e)
        {

        }

        private void Button_agregar_Click(object sender, EventArgs e)
        {
            string SQL = String.Format("INSERT INTO `Horario`(`idHorario`, " +
                                                              "`nombre`, " +
                                                              "`horario_entrada`, " +
                                                              "`horario_salida`) VALUES ('{0}','{1}','{2}','{3}')",
                                                                     textBox_id.Text.ToString(),
                                                                     textBox_idioma.Text.ToString(),
                                                                     comboBox_entrada.SelectedItem.ToString(),
                                                                     comboBox_salida.SelectedItem.ToString());



            ODB.NonQuery(SQL);

            updateLista();

            textBox_id.Text = "";
            textBox_idioma.Text = "";
        }

        private void ListView1_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                ODB.SetCommand(string.Format("SELECT * FROM `Horario` WHERE `nombre` = '{0}'", item.Text.ToString()));
                string[] values = ODB.GetMultiCampos(4);

                textBox_id.Text = values[0];
                textBox_idioma.Text = values[1];
                comboBox_entrada.Text = values[2];
                comboBox_salida.Text = values[3];
            }
        }

        private void Button_eliminar_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                string SQL = String.Format("DELETE FROM `Horario` WHERE `nombre` = '{0}'", item.Text.ToString());
                ODB.NonQuery(SQL);
            }

            textBox_id.Text = "";
            textBox_idioma.Text = "";
            comboBox_entrada.Text = "";
            comboBox_salida.Text = "";
            updateLista();
        }

        private void Button_actualizar_Click(object sender, EventArgs e)
        {
            string SQL = String.Format("UPDATE `Horario` SET `nombre`='{0}', " +
                                                            "`horario_entrada`='{1}', " +
                                                            "`horario_salida`='{2}' WHERE `idArea` = '{3}'", 
                                                            textBox_idioma.Text.ToString(),
                                                            comboBox_entrada.Text.ToString(),
                                                            comboBox_salida.Text.ToString(),
                                                            textBox_id.Text.ToString());
            ODB.NonQuery(SQL);

            updateLista();
        }
    }
}
