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
    public partial class Cursos : Form
    {
        public Cursos()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void Button_agregar_Click(object sender, EventArgs e)
        {
            string SQL = String.Format("INSERT INTO `Cursos`(`idCurso`, `curso`) VALUES ('{0}','{1}')",
                                                                   textBox_id.Text.ToString(),
                                                                   textBox_nombre.Text.ToString());



            ODB.NonQuery(SQL);


            textBox_id.Text = "";
            textBox_nombre.Text = "";
        }

        private void Button_eliminar_Click(object sender, EventArgs e)
        {
            string SQL = String.Format("DELETE FROM `Cursos` WHERE `idDocumento` = '{0}'", textBox_id.Text.ToString());
            ODB.NonQuery(SQL);


            textBox_id.Text = "";
            textBox_nombre.Text = "";
        }

        private void Button_actualizar_Click(object sender, EventArgs e)
        {
            string SQL = String.Format("UPDATE `Cursos` SET `curso`='{0}' WHERE `idCurso` = '{1}'", textBox_nombre.Text.ToString(), textBox_id.Text.ToString());
            ODB.NonQuery(SQL);
        }

        private void Button_buscar_Click(object sender, EventArgs e)
        {
            string SQL = String.Format("SELECT `curso` FROM `Cursos` WHERE `idCurso` = '{0}'", textBox_id.Text.ToString());
            ODB.SetCommand(SQL);
            string[] campos = ODB.GetMultiCampos(1);
            textBox_nombre.Text = campos[0];
        }
    }
}
