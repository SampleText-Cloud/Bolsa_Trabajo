using Ingenieria_Software.Secciones.Reclutadores;
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
    public partial class Trabajadores : Form
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
               cp,
               curso1,
               curso2,
               curso3,
               curso4,
               curso5;

        public Trabajadores()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void updateLosCursos()
        {
            if (comboBox_c1.Text.ToString() != "" && comboBox_c1.Text.ToString() != null)
            {
                updateCurso(textBox_idCandidato.Text.ToString(), comboBox_c1.Text.ToString(), curso1);
            }

            if (comboBox_c2.Text.ToString() != "" && comboBox_c2.Text.ToString() != null)
            {
                updateCurso(textBox_idCandidato.Text.ToString(), comboBox_c2.Text.ToString(), curso2);
            }

            if (comboBox_c3.Text.ToString() != "" && comboBox_c3.Text.ToString() != null)
            {
                updateCurso(textBox_idCandidato.Text.ToString(), comboBox_c3.Text.ToString(), curso3);
            }

            if (comboBox_c4.Text.ToString() != "" && comboBox_c4.Text.ToString() != null)
            {
                updateCurso(textBox_idCandidato.Text.ToString(), comboBox_c4.Text.ToString(), curso4);
            }

            if (comboBox_c5.Text.ToString() != "" && comboBox_c5.Text.ToString() != null)
            {
                updateCurso(textBox_idCandidato.Text.ToString(), comboBox_c5.Text.ToString(), curso5);
            }
        }

        private void updateCurso(string id, string nombre, string curso)
        {
            string SQL = String.Format("UPDATE `Trabajador-Curso` SET `curso`='{0}' WHERE `trabajador` = '{1}' AND `curso` = '{2}'",
                                                                    nombre,
                                                                    id,
                                                                    curso);
            Clipboard.SetText(SQL);
            ODB.NonQuery(SQL);
        }
       

        private void uploadCursos(string id, string nombre)
        {
            string SQL = String.Format("INSERT INTO `Trabajador-Curso`(`trabajador`, `curso`) VALUES ('{0}','{1}')",
                                                                    id,
                                                                    nombre);
            ODB.NonQuery(SQL);
        }
        private void setCursos()
        {
            if(comboBox_c1.Text.ToString() != "" && comboBox_c1.Text.ToString() != null)
            {
                uploadCursos(textBox_idCandidato.Text.ToString(), comboBox_c1.Text.ToString());
                curso1 = comboBox_c1.Text.ToString();
            }

            if (comboBox_c2.Text.ToString() != "" && comboBox_c2.Text.ToString() != null)
            {
                uploadCursos(textBox_idCandidato.Text.ToString(), comboBox_c2.Text.ToString());
                curso2 = comboBox_c2.Text.ToString();
            }

            if (comboBox_c3.Text.ToString() != "" && comboBox_c3.Text.ToString() != null)
            {
                uploadCursos(textBox_idCandidato.Text.ToString(), comboBox_c3.Text.ToString());
                curso3 = comboBox_c3.Text.ToString();
            }

            if (comboBox_c4.Text.ToString() != "" && comboBox_c4.Text.ToString() != null)
            {
                uploadCursos(textBox_idCandidato.Text.ToString(), comboBox_c4.Text.ToString());
                curso4 = comboBox_c4.Text.ToString();
            }

            if (comboBox_c5.Text.ToString() != "" && comboBox_c5.Text.ToString() != null)
            {
                uploadCursos(textBox_idCandidato.Text.ToString(), comboBox_c5.Text.ToString());
                curso5 = comboBox_c5.Text.ToString();
            }
        }
   
        private void Button_agregar_Click(object sender, EventArgs e)
        {
            CreateIfMissing("C:\\SERVIDOR\\DOCUMENTOS\\" + textBox_idCandidato.Text.ToString());
            SetValues();
            setCursos();
            string SQL = String.Format("INSERT INTO `Trabajadores`(`idTrabajador`, " +
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

            SQL = String.Format("INSERT INTO `Trabajador-Horario`(`trabajador`, `horario`) VALUES ('{0}','{1}')",
                                                                  textBox_idCandidato.Text.ToString(),
                                                                  comboBox_horario.Text.ToString());



            ODB.NonQuery(SQL);



        }
        private void CreateIfMissing(string path)
        {
            bool folderExists = Directory.Exists(path);
            if (!folderExists)
                Directory.CreateDirectory(path);
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

        private void Button_eliminar_Click(object sender, EventArgs e)
        {
            SetValues();
            string SQL = string.Format("DELETE FROM `Trabajadores` WHERE `idTrabajador` = '{0}';", id);
            ODB.NonQuery(SQL);
  
            Clipboard.SetText(SQL);
            

            SQL = String.Format("DELETE FROM `Trabajador-Horario` WHERE `trabajador` = '{0}'", textBox_idCandidato.Text.ToString());
            ODB.NonQuery(SQL);
            clear();

            SQL = String.Format("DELETE FROM `Trabajador-Curso` WHERE `trabajador` = '{0}'", textBox_idCandidato.Text.ToString());
            ODB.NonQuery(SQL);
            clear();


        }
        private void clear()
        {
            foreach (TextBox var in layout_datos.Controls.OfType<TextBox>())
            {
                var.Text = "";
            }

            comboBox_horario.Text = "";
            comboBox_perfil.Text = "";
        }

        private void Button_actualizar_Click(object sender, EventArgs e)
        {
            SetValues();
            string SQL = String.Format("UPDATE `Trabajadores` SET `nombres`='{0}'," +
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
                                                              "`ine`='{20}' WHERE `idTrabajador`='{21}'",

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


            SQL = String.Format("UPDATE `Trabajador-Horario` SET `horario`='{0}' WHERE `trabajador` = '{1}'", comboBox_horario.Text.ToString(), textBox_idCandidato.Text.ToString());
            ODB.NonQuery(SQL);

            updateLosCursos();
        }

        private void Button_buscar_Click(object sender, EventArgs e)
        {
            SetValues();
            clear();
            string SQL = string.Format("SELECT * FROM `Trabajadores` WHERE `idTrabajador` = '{0}'", id);
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

            SQL = String.Format("SELECT `horario` FROM `Trabajador-Horario` WHERE `trabajador` = '{0}'", textBox_idCandidato.Text.ToString());
            ODB.SetCommand(SQL);
            string[] campos = ODB.GetMultiCampos(1);
            comboBox_horario.Text = campos[0];

           SQL = String.Format("SELECT `curso` FROM `Trabajador-Curso` WHERE `trabajador` = '{0}'", textBox_idCandidato.Text.ToString());
            ODB.SetCommand(SQL);
            Clipboard.SetText(SQL);
            string[] campos2 = ODB.GetMultiDatos();
            string[] agregados = new string[5];
            int i=0;
            foreach(string var in campos2)
            {
                if(var != "" && var != null)
                {
                    agregados[i] = var;
                    i++;
                }
            }
            setValuesForCursos(agregados);

        }
        private void setValuesForCursos(string[] items)
        {
            comboBox_c1.Text = items[0];
            comboBox_c2.Text = items[1];
            comboBox_c3.Text = items[2];
            comboBox_c4.Text = items[3];
            comboBox_c5.Text = items[4];

            curso1 = items[0];
            curso2 = items[1];
            curso3 = items[2];
            curso4 = items[3];
            curso5 = items[4];

        }
        private void Button1_Click(object sender, EventArgs e)
        {
            DialogResult result = new Mensajes.Tipos.Conversion("CANDIDATO","ARCHIVO MUERTO").ShowDialog();
            switch (result)
            {
                case DialogResult.Yes:
                    ConvertToCandidato();
                    break;
                case DialogResult.No:
                    ConvertToArchivoMuerto();
                    break;
                case DialogResult.Cancel:
                    break;
            }
        }
        private void ConvertToCandidato()
        {
            SetValues();
            string SQL = string.Format("INSERT INTO `Candidato` SELECT * FROM `Trabajadores` WHERE `idTrabajador` = '{0}'", id);
            ODB.NonQuery(SQL);
            SQL = string.Format("DELETE FROM `Trabajadores` WHERE `idTrabajador` = '{0}'", id);
            ODB.NonQuery(SQL);
            clear();

        }
        private void ConvertToArchivoMuerto()
        {

            SetValues();
            string SQL = string.Format("INSERT INTO `ArchivoMuerto` SELECT * FROM `Trabajadores` WHERE `idTrabajador` = '{0}'", id);
            ODB.NonQuery(SQL);
            SQL = string.Format("DELETE FROM `Trabajadores` WHERE `idTrabajador` = '{0}'", id);
            ODB.NonQuery(SQL);
            SQL = string.Format("INSERT INTO `MotivosArchivoMuerto`(`id`, `Motivo`) VALUES ('{0}','{1}')", id, Administrador.motivo);
            ODB.NonQuery(SQL);
            clear();

        }

        private void Button5_Click(object sender, EventArgs e)
        {

        }

        private void Trabajadores_Load(object sender, EventArgs e)
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


            ODB.SetCommand("SELECT * FROM `Horario`");
            string[] horarios = ODB.GetMultiId();

            foreach (string nac in horarios)
            {
                if (nac != null && nac != "")
                {
                    comboBox_horario.Items.Add(nac);
                }
            }

            ODB.SetCommand("SELECT * FROM `Puesto_Tipo`");
            string[] puestos = ODB.GetMultiId();

            foreach (string nac in puestos)
            {
                if (nac != null && nac != "")
                {
                    comboBox_perfil.Items.Add(nac);
                }
            }
            comboBox_c1.Items.Add("");
            comboBox_c2.Items.Add("");
            comboBox_c3.Items.Add("");
            comboBox_c4.Items.Add("");
            comboBox_c5.Items.Add("");

            ODB.SetCommand("SELECT * FROM `Cursos`");
            string[] Cursos = ODB.GetMultiId();

            foreach (string nac in Cursos)
            {
                if (nac != null && nac != "")
                {
                    comboBox_c1.Items.Add(nac);
                    comboBox_c2.Items.Add(nac);
                    comboBox_c3.Items.Add(nac);
                    comboBox_c4.Items.Add(nac);
                    comboBox_c5.Items.Add(nac);
                }
            }
        }
    }
}
