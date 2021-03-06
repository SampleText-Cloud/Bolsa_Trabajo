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
            updateLista();
        }
        private void updateLista()
        {
            listView1.Clear();
            ODB.SetCommand("SELECT * FROM `PerfilEmpresa`");
            string[] areas = ODB.GetMultiId();

            foreach (string area in areas)
            {
                if (area != null && area != "")
                {
                    listView1.Items.Add(area);
                }
            }
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
            string SQL = String.Format("INSERT INTO `PerfilEmpresa`(`idPerfil`, " +
                                                                    "`tipo`, " +
                                                                    "`puesto`, " +
                                                                    "`idExperiencia`, " +
                                                                    "`escolaridad`, " +
                                                                    "`descripcion`) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}')",
                                                                    textBox_id.Text.ToString(),
                                                                    comboBox_tipo.Text.ToString(),
                                                                    comboBox_puesto.Text.ToString(),
                                                                    textBox_idExperiencia.Text.ToString(),
                                                                    comboBox_escolaridad.Text.ToString(),
                                                                    richTextBox_descripcion.Text.ToString());



            ODB.NonQuery(SQL);
            new Mensajes.Tipos.MsgBoxOK("Operacion exitosa!");
            clear();
            updateLista();
        }

        private void Button_eliminar_Click(object sender, EventArgs e)
        {
            string SQL = String.Format("DELETE FROM `PerfilEmpresa` WHERE `idPerfil` = '{0}'", textBox_id.Text.ToString());
            ODB.NonQuery(SQL);
            clear();
            updateLista();
        }

        private void clear()
        {
            textBox_id.Text = "";
            comboBox_tipo.Text = "";
            comboBox_puesto.Text = "";
            textBox_idExperiencia.Text = "";
            comboBox_escolaridad.Text = "";
            richTextBox_descripcion.Text = "";
        }

        private void Button_actualizar_Click(object sender, EventArgs e)
        {
            string SQL = String.Format("UPDATE `PerfilEmpresa` SET `tipo`='{0}'," +
                                                                   "`puesto`='{1}'," +
                                                                   "`idExperiencia`='{2}'," +
                                                                   "`escolaridad`='{3}'," +
                                                                   "`descripcion`='{4}'",
                                                                      comboBox_tipo.Text.ToString(),
                                                                      comboBox_puesto.Text.ToString(),
                                                                      textBox_idExperiencia.Text.ToString(),
                                                                      comboBox_escolaridad.Text.ToString(),
                                                                      richTextBox_descripcion.Text.ToString());
            ODB.NonQuery(SQL);

        }

        private void ListView1_Click(object sender, EventArgs e)
        {
            clear();
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                
                string SQL = string.Format("SELECT * FROM `PerfilEmpresa` WHERE `tipo` = '{0}'", item.Text.ToString());
                ODB.SetCommand(SQL);
                string[] values = ODB.GetMultiCampos(6);
                

                textBox_id.Text = values[0];
                comboBox_tipo.Text = values[1];
                comboBox_puesto.Text = values[2];
                textBox_idExperiencia.Text = values[3];
                comboBox_escolaridad.Text = values[4];
                richTextBox_descripcion.Text = values[5];


            }
        }
    }
}
