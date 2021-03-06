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

namespace Ingenieria_Software.Secciones.Empresa
{
    public partial class ArchivoMuerto : Form
    {
        string antecedentes = " ";
        string identificacion = " ";
        string solicitud = " ";
        string foto = " ";

        string id,
               nombre,
               ap_p,
               ap_m,
               curp,
               rfc,
               nacionalidad,
               fechaNac,
               sexo,
               fechaIngreso,
               idPerfil,
               telefono,
               correo,
               colonia,
               calle,
               interior,
               exterior,
               cp;

        private void Button1_Click(object sender, EventArgs e)
        {
            DialogResult result = new Mensajes.Tipos.Conversion("CANDIDATO","TRABAJADOR").ShowDialog();
            switch (result)
            {
                case DialogResult.Yes:
                    ConvertToCandidato();
                    break;
                case DialogResult.No:
                    ConvertToTrabajador();
                    break;
                case DialogResult.Cancel:
                    break;
            }
        }
        private void ConvertToCandidato()
        {
            SetValues();
            string SQL = string.Format("INSERT INTO `Candidato` SELECT * FROM `ArchivoMuerto` WHERE `idArchivoMuerto` = '{0}'", id);
            ODB.NonQuery(SQL);
            SQL = string.Format("DELETE FROM `ArchivoMuerto` WHERE `idArchivoMuerto` = '{0}'", id);
            ODB.NonQuery(SQL);
            clear();

        }

        private void ConvertToTrabajador()
        {
            SetValues();
            string SQL = string.Format("INSERT INTO `Trabajadores` SELECT * FROM `ArchivoMuerto` WHERE `idArchivoMuerto` = '{0}'", id);
            ODB.NonQuery(SQL);
            SQL = string.Format("DELETE FROM `ArchivoMuerto` WHERE `idArchivoMuerto` = '{0}'", id);
            ODB.NonQuery(SQL);
            clear();

        }

        private void Button_buscar_Click(object sender, EventArgs e)
        {
            SetValues();
            clear();
            string SQL = string.Format("SELECT * FROM `ArchivoMuerto` WHERE `idArchivoMuerto` = '{0}'", id);
            ODB.SetCommand(SQL);
            string[] values = ODB.GetMultiCampos(22);
            textBox_idCandidato.Text = values[0];
            textBox_nombre.Text = values[1];
            textBox_apellido_paterno.Text = values[2];
            textBox_apellido_materno.Text = values[3];
            textBox_curp.Text = values[4];
            textBox_rfc.Text = values[5];
            comboBox_nacionalidad.Text = values[6];
            dateTimePicker_nacimiento.Value = DateTime.Parse(values[7]);
            comboBox_sexo.Text = values[8];
            dateTimePicker_ingreso.Value = DateTime.Parse(values[9]);
            comboBox_perfil.Text = values[10];
            textBox_telefono.Text = values[11];
            textBox_correo.Text = values[12];
            textBox_colonia.Text = values[13];
            textBox_calle.Text = values[14];
            textBox_no_int.Text = values[15];
            textBox_no_ext.Text = values[16];
            textBox_cp.Text = values[17];
            antecedentes = values[18];
            solicitud = values[19];
            foto = values[20];
            identificacion = values[21];
        }

        private void Button_actualizar_Click(object sender, EventArgs e)
        {
            SetValues();
            string SQL = String.Format("UPDATE `ArchivoMuerto` SET `nombres`='{0}'," +
                                                              "`a_paterno`='{1}'," +
                                                              "`a_materno`='{2}'," +
                                                              "`curp`='{3}'," +
                                                              "`rfc`='{4}'," +
                                                              "`nacionalidad`='{5}'," +
                                                              "`fechaNac`='{6}'," +
                                                              "`sexo`='{7}'," +
                                                              "`fechaIngreso`='{8}'," +
                                                              "`idPerfil`='{9}'," +
                                                              "`telefono`='{10}'," +
                                                              "`correo`='{11}'," +
                                                              "`dir_colonia`='{12}'," +
                                                              "`dir_calle`='{13}'," +
                                                              "`dir_no_int`='{14}'," +
                                                              "`dir_no_ext`='{15}'," +
                                                              "`dir_cp`='{16}'," +
                                                              "`cartaAntecedentes`='{17}'," +
                                                              "`solicitud`='{18}'," +
                                                              "`foto`='{19}'," +
                                                              "`ine`='{20}' WHERE `idArchivoMuerto`='{21}'",

                                                                     nombre,
                                                                     ap_p,
                                                                     ap_m,
                                                                     curp,
                                                                     rfc,
                                                                     nacionalidad,
                                                                     fechaNac,
                                                                     sexo,
                                                                     fechaIngreso,
                                                                     idPerfil,
                                                                     telefono,
                                                                     correo,
                                                                     colonia,
                                                                     calle,
                                                                     interior,
                                                                     exterior,
                                                                     cp,
                                                                     antecedentes,
                                                                     solicitud,
                                                                     foto,
                                                                     identificacion,
                                                                     id);



            ODB.NonQuery(SQL);
            Clipboard.SetText(SQL);
        }

        private void Button_eliminar_Click(object sender, EventArgs e)
        {
            SetValues();
            string SQL = string.Format("DELETE FROM `ArchivoMuerto` WHERE `idArchivoMuerto` = '{0}';", id);
            ODB.NonQuery(SQL);
            clear();
            Clipboard.SetText(SQL);
        }

        public ArchivoMuerto()
        {
            InitializeComponent();
            CenterToScreen();
        }
        private void CreateIfMissing(string path)
        {
            bool folderExists = Directory.Exists(path);
            if (!folderExists)
                Directory.CreateDirectory(path);
        }

        private void clear()
        {
            foreach (TextBox var in layout_datos.Controls.OfType<TextBox>())
            {
                var.Text = "";
            }
        }
        private void SetValues()
        {
            id = textBox_idCandidato.Text.ToString();
            nombre = textBox_nombre.Text.ToString();
            ap_p = textBox_apellido_paterno.Text.ToString();
            ap_m = textBox_apellido_materno.Text.ToString();
            curp = textBox_curp.Text.ToString();
            rfc = textBox_rfc.Text.ToString();
            nacionalidad = comboBox_nacionalidad.Text.ToString();
            fechaNac = dateTimePicker_nacimiento.Text.ToString();
            sexo = comboBox_sexo.Text.ToString();
            fechaIngreso = dateTimePicker_ingreso.Text.ToString();
            idPerfil = comboBox_perfil.Text.ToString();
            telefono = textBox_telefono.Text.ToString();
            correo = textBox_correo.Text.ToString();
            colonia = textBox_colonia.Text.ToString();
            calle = textBox_calle.Text.ToString();
            interior = textBox_no_int.Text.ToString();
            exterior = textBox_no_ext.Text.ToString();
            cp = textBox_cp.Text.ToString();
        }


        private void Button_agregar_Click(object sender, EventArgs e)
        {
            CreateIfMissing("C:\\SERVIDOR\\DOCUMENTOS\\" + textBox_idCandidato.Text.ToString());
            SetValues();
            string SQL = String.Format("INSERT INTO `ArchivoMuerto`(`idArchivoMuerto`, " +
                                                                     "`nombres`, " +
                                                                     "`a_paterno`, " +
                                                                     "`a_materno`, " +
                                                                     "`curp`, " +
                                                                     "`rfc`, " +
                                                                     "`nacionalidad`, " +
                                                                     "`fechaNac`, " +
                                                                     "`sexo`, " +
                                                                     "`fechaIngreso`, " +
                                                                     "`idPerfil`, " +
                                                                     "`telefono`, " +
                                                                     "`correo`, " +
                                                                     "`dir_colonia`, " +
                                                                     "`dir_calle`, " +
                                                                     "`dir_no_int`, " +
                                                                     "`dir_no_ext`, " +
                                                                     "`dir_cp`, " +
                                                                     "`cartaAntecedentes`, " +
                                                                     "`solicitud`, " +
                                                                     "`foto`, " +
                                                                     "`ine`) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}','{15}','{16}','{17}','{18}','{19}','{20}','{21}')",
                                                                     id,
                                                                     nombre,
                                                                     ap_p,
                                                                     ap_m,
                                                                     curp,
                                                                     rfc,
                                                                     nacionalidad,
                                                                     fechaNac,
                                                                     sexo,
                                                                     fechaIngreso,
                                                                     idPerfil,
                                                                     telefono,
                                                                     correo,
                                                                     colonia,
                                                                     calle,
                                                                     interior,
                                                                     exterior,
                                                                     cp,
                                                                     antecedentes,
                                                                     solicitud,
                                                                     foto,
                                                                     identificacion);



            ODB.NonQuery(SQL);
            Clipboard.SetText(SQL);
        }

        private void ArchivoMuerto_Load(object sender, EventArgs e)
        {
            ODB.SetCommand("SELECT * FROM `Nacionalidad`");
            string[] nacionalidadesDisponibles = ODB.GetMultiId();

            foreach (string nac in nacionalidadesDisponibles)
            {
                if (nac != null && nac != "")
                {
                    comboBox_nacionalidad.Items.Add(nac);
                }
            }

            ODB.SetCommand("SELECT * FROM `Puesto_Tipo`");
            string[] perfiles = ODB.GetMultiId();

            foreach (string nac in perfiles)
            {
                if (nac != null && nac != "")
                {
                    comboBox_perfil.Items.Add(nac);
                }
            }
        }
    }
}
