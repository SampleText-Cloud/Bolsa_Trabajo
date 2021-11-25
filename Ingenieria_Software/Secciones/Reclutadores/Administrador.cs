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
            DialogResult result = new Mensajes.Tipos.Conversion("TRABAJADOR", "ARCHIVO MUERTO").ShowDialog();
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
        
       
     
  
        private void Administrador_Load(object sender, EventArgs e)
        {
            ODB.SetCommand("SELECT * FROM `Nacionalidad`");
            string[] nacionalidadesDisponibles = ODB.GetMultiId();
            
            foreach(string nac in nacionalidadesDisponibles)
            {
                if(nac != null && nac != "")
                {
                    comboBox_nacionalidad.Items.Add(nac);
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
            comboBox_perfil.Text = values[10];
            textBox_telefono.Text = values[11];
            textBox_correo.Text = values[12];
            textBox_colonia.Text = values[13];
            textBox_calle.Text = values[14];
            textBox_no_int.Text = values[15];
            textBox_no_ext.Text = values[16];
            textBox_cp.Text = values[17];
            textBox_doc_1.Text = values[18];
            textBox_doc_2.Text = values[19];
            textBox_doc_3.Text = values[20];
            textBox_doc_4.Text = values[21];

            searchDoc(values);
            
            
        }

        private void searchDoc(string[] values)
        {
            if (textBox_doc_1.Text.ToString() != "" && textBox_doc_1.Text.ToString() != null)
            {
                string SQL = String.Format("SELECT `documento` FROM `Documentos` WHERE `idDocumento` = '{0}'", textBox_doc_1.Text.ToString());
                ODB.SetCommand(SQL);
                string[] campos = ODB.GetMultiCampos(1);
                textBox_doc_1_nombre.Text = campos[0];
            }

            if (textBox_doc_2.Text.ToString() != "" && textBox_doc_2.Text.ToString() != null)
            {
                string SQL = String.Format("SELECT `documento` FROM `Documentos` WHERE `idDocumento` = '{0}'", textBox_doc_2.Text.ToString());
                ODB.SetCommand(SQL);
                string[] campos = ODB.GetMultiCampos(1);
                textBox_doc_2_nombre.Text = campos[0];
            }

            if (textBox_doc_3.Text.ToString() != "" && textBox_doc_3.Text.ToString() != null)
            {
                string SQL = String.Format("SELECT `documento` FROM `Documentos` WHERE `idDocumento` = '{0}'", textBox_doc_3.Text.ToString());
                ODB.SetCommand(SQL);
                string[] campos = ODB.GetMultiCampos(1);
                textBox_doc_3_nombre.Text = campos[0];
            }

            if (textBox_doc_4.Text.ToString() != "" && textBox_doc_4.Text.ToString() != null)
            {
                string SQL = String.Format("SELECT `documento` FROM `Documentos` WHERE `idDocumento` = '{0}'", textBox_doc_4.Text.ToString());
                ODB.SetCommand(SQL);
                string[] campos = ODB.GetMultiCampos(1);
                textBox_doc_4_nombre.Text = campos[0];
            }

            if (textBox_doc_5.Text.ToString() != "" && textBox_doc_5.Text.ToString() != null)
            {
                string SQL = String.Format("SELECT `documento` FROM `Documentos` WHERE `idDocumento` = '{0}'", textBox_doc_5.Text.ToString());
                ODB.SetCommand(SQL);
                string[] campos = ODB.GetMultiCampos(1);
                textBox_doc_5_nombre.Text = campos[0];
            }
        }
        private void deleteDocs()
        {
            if(textBox_doc_1.Text.ToString() != "" && textBox_doc_1.Text.ToString() != null)
            {
                string SQL = String.Format("DELETE FROM `Documentos` WHERE `idDocumento` = '{0}'", textBox_doc_1.Text.ToString());
                ODB.NonQuery(SQL);
            }

            if (textBox_doc_2.Text.ToString() != "" && textBox_doc_1.Text.ToString() != null)
            {
                string SQL = String.Format("DELETE FROM `Documentos` WHERE `idDocumento` = '{0}'", textBox_doc_2.Text.ToString());
                ODB.NonQuery(SQL);
            }

            if (textBox_doc_3.Text.ToString() != "" && textBox_doc_1.Text.ToString() != null)
            {
                string SQL = String.Format("DELETE FROM `Documentos` WHERE `idDocumento` = '{0}'", textBox_doc_3.Text.ToString());
                ODB.NonQuery(SQL);
            }

            if (textBox_doc_4.Text.ToString() != "" && textBox_doc_1.Text.ToString() != null)
            {
                string SQL = String.Format("DELETE FROM `Documentos` WHERE `idDocumento` = '{0}'", textBox_doc_4.Text.ToString());
                ODB.NonQuery(SQL);
            }

            if (textBox_doc_5.Text.ToString() != "" && textBox_doc_1.Text.ToString() != null)
            {
                string SQL = String.Format("DELETE FROM `Documentos` WHERE `idDocumento` = '{0}'", textBox_doc_5.Text.ToString());
                ODB.NonQuery(SQL);
            }
        }
        private void Button_eliminar_Click(object sender, EventArgs e)
        {
            SetValues();
            deleteDocs();
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
            antecedentes = textBox_doc_1.Text.ToString();
            solicitud = textBox_doc_2.Text.ToString();
            foto = textBox_doc_3.Text.ToString();
            identificacion = textBox_doc_4.Text.ToString();
        }
        private void uploadDocumentos(string id, string nombre)
        {
            string SQL = String.Format("INSERT INTO `Documentos`(`idDocumento`, `documento`) VALUES ('{0}','{1}')",
                                                                    id,
                                                                    nombre);
            ODB.NonQuery(SQL);
        }

        private void setDocumentos()
        {
            if(textBox_doc_1.Text.ToString() != "" && textBox_doc_1.Text.ToString() != null)
            {
                uploadDocumentos(textBox_doc_1.Text.ToString(), textBox_doc_1_nombre.Text.ToString());
                antecedentes = textBox_doc_1.Text.ToString();
            }

            if (textBox_doc_2.Text.ToString() != "" && textBox_doc_2.Text.ToString() != null)
            {
                uploadDocumentos(textBox_doc_2.Text.ToString(), textBox_doc_2_nombre.Text.ToString());
                solicitud = textBox_doc_2.Text.ToString();
            }

            if (textBox_doc_3.Text.ToString() != "" && textBox_doc_3.Text.ToString() != null)
            {
                uploadDocumentos(textBox_doc_3.Text.ToString(), textBox_doc_3_nombre.Text.ToString());
                foto = textBox_doc_3.Text.ToString();
            }

            if (textBox_doc_4.Text.ToString() != "" && textBox_doc_4.Text.ToString() != null)
            {
                uploadDocumentos(textBox_doc_4.Text.ToString(), textBox_doc_4_nombre.Text.ToString());
                identificacion = textBox_doc_4.Text.ToString();
            }

            if (textBox_doc_5.Text.ToString() != "" && textBox_doc_5.Text.ToString() != null)
            {
                uploadDocumentos(textBox_doc_5.Text.ToString(), textBox_doc_5_nombre.Text.ToString());
            }
        }

        private void Button_agregar_Click_1(object sender, EventArgs e)
        {
            SetValues();
            setDocumentos();
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
