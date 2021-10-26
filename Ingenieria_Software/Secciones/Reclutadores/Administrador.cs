using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ingenieria_Software.Secciones.Reclutadores
{
    public partial class Administrador : Form
    {
        public Administrador()
        {
            InitializeComponent();
            CenterToScreen();
        }
        Secciones.Reclutadores.reclutador trabajador = new Secciones.Reclutadores.reclutador();

        private void clear()
        {
            foreach(TextBox var in layout_datos.Controls.OfType<TextBox>())
            {
                var.Text = "";
            }
        }
        private void SetAllValues()
        {
            trabajador.SetNombre(textBox_nombre.Text);
            trabajador.SetApellidoPaterno(textBox_apellido_paterno.Text);
            trabajador.SetApellidoMaterno(textBox_apellido_materno.Text);
            trabajador.SetCurp(textBox_curp.Text);
            trabajador.SetRfc(textBox_rfc.Text);

            trabajador.SetDireccionColonia(textBox_colonia.Text);
            trabajador.SetDireccionCalle(textBox_calle.Text);
            trabajador.SetDireccionNoInt(textBox_no_int.Text);
            trabajador.SetDireccionNoExt(textBox_no_ext.Text);
            trabajador.SetDireccionCp(textBox_cp.Text);

            trabajador.setTelefono(textBox_telefono.Text);
            trabajador.SetCorreo(textBox_correo.Text);
        }
        private void GetAllValues()
        {
            trabajador.GetNombre();
            trabajador.GetApellidoPaterno();
            trabajador.GetApellidoMaterno();
            trabajador.GetCurp();
            trabajador.GetRfc();

            trabajador.GetDireccionColonia();
            trabajador.GetDireccionCalle();
            trabajador.GetDireccionNoInt();
            trabajador.GetDireccionNoExt();
            trabajador.GetDireccionCp();

            trabajador.GetTelefono();
            trabajador.GetCorreo();
        }

        private void Button_agregar_Click(object sender, EventArgs e)
        {
            SetAllValues();
            trabajador.InsertarRecluta();
            textBox_id.Text = trabajador.GetId();

            button_eliminar.Enabled = true;
            button_actualizar.Enabled = true;
        }

        private void Button_eliminar_Click(object sender, EventArgs e)
        {
            trabajador.EliminarRecluta(textBox_id.Text);
            clear();
        }

        private void Button_buscar_Click(object sender, EventArgs e)
        {
            
            trabajador.BuscarRecluta(textBox_id.Text.ToString()) ;
            clear();
            GetAllValues();
            
        }

        private void Button_actualizar_Click(object sender, EventArgs e)
        {
            SetAllValues();
            trabajador.ActualizarRecluta(textBox_id.Text);
        }

        private void Button_documentos_Click(object sender, EventArgs e)
        {

            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.pdf)|*.pdf|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }
                }
            }
            new Mensajes.Tipos.MsgBoxOK(filePath).ShowDialog();
        }
    }
}
