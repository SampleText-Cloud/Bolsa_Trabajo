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
    public partial class Documentos : Form
    {
        public Documentos()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void Button_agregar_Click(object sender, EventArgs e)
        {
            string SQL = String.Format("INSERT INTO `Documentos`(`idDocumento`, `documento`) VALUES ('{0}','{1}')",
                                                                    textBox_id.Text.ToString(),
                                                                    textBox_nombre.Text.ToString());



            ODB.NonQuery(SQL);


            textBox_id.Text = "";
            textBox_nombre.Text = "";
        }

        private void Button_eliminar_Click(object sender, EventArgs e)
        {
            
            string SQL = String.Format("DELETE FROM `Documentos` WHERE `idDocumento` = '{0}'", textBox_id.Text.ToString());
            ODB.NonQuery(SQL);
            

            textBox_id.Text = "";
            textBox_nombre.Text = "";
        }

        private void Button_actualizar_Click(object sender, EventArgs e)
        {
            string SQL = String.Format("UPDATE `Documentos` SET `documento`='{0}' WHERE `idDocumento` = '{1}'", textBox_nombre.Text.ToString(), textBox_id.Text.ToString());
            ODB.NonQuery(SQL);
        }

        private void Button_buscar_Click(object sender, EventArgs e)
        {
            string SQL = String.Format("SELECT `documento` FROM `Documentos` WHERE `idDocumento` = '{0}'",textBox_id.Text.ToString());
            ODB.SetCommand(SQL);
            string[] campos= ODB.GetMultiCampos(1);
            textBox_nombre.Text = campos[0];
        }
    }
}
