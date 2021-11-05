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
        public static string motivo;
        string antecedentes=" ";
        string identificacion=" ";
        string solicitud=" ";
        string foto=" ";

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

        private void Button_actualizar_Click(object sender, EventArgs e)
        {
            SetValues();
            string SQL = String.Format("UPDATE `Candidato` SET `nombres`='{0}'," +
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
                                                              "`ine`='{20}' WHERE `idCandidato`='{21}'",
                                                                     
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

        private void Button1_Click(object sender, EventArgs e)
        {
            DialogResult result = new Mensajes.Tipos.Conversion().ShowDialog();
            switch (result)
            {
                case DialogResult.Yes:
                    ConvertToTrabajador();
                    break;
                case DialogResult.No:
                    ConvertToArchivoMuerto();
                    break;
                case DialogResult.Cancel:
                    break;
            }
        }

        private void ConvertToTrabajador()
        {
            SetValues();
            string SQL = string.Format("INSERT INTO `Trabajadores` SELECT * FROM `Candidato` WHERE `idCandidato` = '{0}'", id);
            ODB.NonQuery(SQL);
            SQL = string.Format("DELETE FROM `Candidato` WHERE `idCandidato` = '{0}'", id);
            ODB.NonQuery(SQL);
            clear();

        }

        
        private void ConvertToArchivoMuerto()
        {
      
            SetValues();
            string SQL = string.Format("INSERT INTO `ArchivoMuerto` SELECT * FROM `Candidato` WHERE `idCandidato` = '{0}'", id);
            ODB.NonQuery(SQL);
            SQL = string.Format("DELETE FROM `Candidato` WHERE `idCandidato` = '{0}'", id);
            ODB.NonQuery(SQL);
            SQL = string.Format("INSERT INTO `MotivosArchivoMuerto`(`id`, `Motivo`) VALUES ('{0}','{1}')", id, motivo);
            ODB.NonQuery(SQL);
            clear();

        }
        
        private void Button_antecedentes_Click(object sender, EventArgs e)
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
            if (filePath != null && filePath != "")
            {
                antecedentes = Path.GetFileName(filePath);
                new Mensajes.Tipos.MsgBoxOK(filePath).ShowDialog();
                button_antecedentescheck.BackColor = Color.Green;
            }
        }

        private void Button_identificacion_Click(object sender, EventArgs e)
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
            if (filePath != null && filePath != "")
            {
                identificacion = Path.GetFileName(filePath);
                new Mensajes.Tipos.MsgBoxOK(filePath).ShowDialog();
                button_identificacioncheck.BackColor = Color.Green;
            }
        }

        private void Button_solicitud_Click(object sender, EventArgs e)
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
            if (filePath != null && filePath != "")
            {
                solicitud = Path.GetFileName(filePath);
                new Mensajes.Tipos.MsgBoxOK(filePath).ShowDialog();
                button_solicitudcheck.BackColor = Color.Green;
            }
        }

        private void CreateIfMissing(string path)
        {
            bool folderExists = Directory.Exists(path);
            if (!folderExists)
                Directory.CreateDirectory(path);
        }
        private void Administrador_Load(object sender, EventArgs e)
        {
            ODB.SetCommand("SELECT * FROM `Idiomas`");
            string[] nacionalidadesDisponibles = ODB.GetMultiId();
            
            foreach(string nac in nacionalidadesDisponibles)
            {
                if(nac != null && nac != "")
                {
                    comboBox_nacionalidad.Items.Add(nac);
                }
            }
        }

        private void checkNacionalidad()
        {
            ODB.SetCommand("SELECT * FROM `Nacionalidad`");
            string[] lista = ODB.GetMultiId();
            foreach (string area in lista)
            {
                if (area != null && area != "")
                {
                    comboBox_nacionalidad.Items.Add(area);
                }
            }
        }

        private void Button_buscar_Click(object sender, EventArgs e)
        {
            SetValues();
            clear();
            string SQL = string.Format("SELECT * FROM `Candidato` WHERE `idCandidato` = '{0}'",id);
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
            textBox_idPerfil.Text = values[10];
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

        private void Button_eliminar_Click(object sender, EventArgs e)
        {
            SetValues();
            string SQL = string.Format("DELETE FROM `Candidato` WHERE `idCandidato` = '{0}';",id);
            ODB.NonQuery(SQL);
            clear();
            Clipboard.SetText(SQL);
        }

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


        
        private void DateTimePicker_ingreso_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Button_foto_Click(object sender, EventArgs e)
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
            if(filePath != null && filePath != "")
            {
                foto = Path.GetFileName(filePath);
                new Mensajes.Tipos.MsgBoxOK(filePath).ShowDialog();
                button_fotocheck.BackColor = Color.Green;
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
            idPerfil = textBox_idPerfil.Text.ToString();
            telefono = textBox_telefono.Text.ToString();
            correo = textBox_correo.Text.ToString();
            colonia = textBox_colonia.Text.ToString();
            calle = textBox_calle.Text.ToString();
            interior = textBox_no_int.Text.ToString();
            exterior = textBox_no_ext.Text.ToString();
            cp = textBox_cp.Text.ToString();
        }

        private void Button_agregar_Click_1(object sender, EventArgs e)
        {
            CreateIfMissing("C:\\SERVIDOR\\DOCUMENTOS\\" + textBox_idCandidato.Text.ToString());
            SetValues();
            string SQL = String.Format("INSERT INTO `Candidato`(`idCandidato`, " +
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
    }

    
}
