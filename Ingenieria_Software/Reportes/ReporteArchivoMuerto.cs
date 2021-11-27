using SpreadsheetLight;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ingenieria_Software.Reportes
{
    public partial class ReporteArchivoMuerto : Form
    {
        public ReporteArchivoMuerto()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private string SQL;
        private string defaultSQL = "SELECT `idArchivoMuerto`, " +
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
                                        "`correo` FROM `ArchivoMuerto`";
        private string filtro;
        private string especifico;

        private void ReporteArchivoMuerto_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("ID", "ID Candidato");
            dataGridView1.Columns.Add("Nombre", "Nombre");
            dataGridView1.Columns.Add("Apellido Paterno", "Apellido Paterno");
            dataGridView1.Columns.Add("Apellido Materno", "Apellido Materno");
            dataGridView1.Columns.Add("Curp", "Curp");

            dataGridView1.Columns.Add("RFC", "RFC");
            dataGridView1.Columns.Add("Nacionalidad", "Nacionalidad");
            dataGridView1.Columns.Add("Fecha de Nacimiento", "Fecha de Nacimiento");
            dataGridView1.Columns.Add("Sexo", "Sexo");
            dataGridView1.Columns.Add("Fecha de ingreso", "Fecha de ingreso");

            //dataGridView1.Columns.Add("Perfil", "Perfil");
            dataGridView1.Columns.Add("Telefono", "Telefono");
            dataGridView1.Columns.Add("Correo", "Correo");

            ODB.SetCommand(defaultSQL);
            string[,] values = ODB.GetReporte1();

            for (int i = 0; i < 400; i++)
            {
                if (values[i, 0] != "" && values[i, 0] != null)
                {

                    dataGridView1.Rows.Add(values[i, 0],
                                    values[i, 1],
                                    values[i, 2],
                                    values[i, 3],
                                    values[i, 4],

                                    values[i, 5],
                                    values[i, 6],
                                    values[i, 7],
                                    values[i, 8],
                                    values[i, 9],

                                    //values[i, 10],
                                    values[i, 11],
                                    values[i, 12]);
                }
            }

        }

        private void loadCandidato()
        {
            comboBox_perfil.Items.Clear();
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

        private void loadNacionalidad()
        {
            comboBox_perfil.Items.Clear();
            ODB.SetCommand("SELECT * FROM `Nacionalidad`");
            string[] puestos = ODB.GetMultiId();

            foreach (string nac in puestos)
            {
                if (nac != null && nac != "")
                {
                    comboBox_perfil.Items.Add(nac);
                }
            }
        }

        private void loadSexo()
        {
            comboBox_perfil.Items.Clear();
            comboBox_perfil.Items.Add("Hombre");
            comboBox_perfil.Items.Add("Mujer");
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*General
            Perfil
            Nacionalidad
            Sexo*/

            if (comboBox1.SelectedItem.ToString() == "General")
            {
                filtro = "";
                especifico = "";
            }
            /*if (comboBox1.SelectedItem.ToString() == "Perfil")
            {
                filtro = " WHERE `idPerfil`=";
                loadCandidato();
            }*/

            if (comboBox1.SelectedItem.ToString() == "Nacionalidad")
            {
                filtro = " WHERE `nacionalidad`=";
                loadNacionalidad();
            }

            if (comboBox1.SelectedItem.ToString() == "Sexo")
            {
                filtro = " WHERE `sexo`=";
                loadSexo();
            }
        }

        private void ComboBox_perfil_SelectedIndexChanged(object sender, EventArgs e)
        {
            especifico = "'" + comboBox_perfil.Text.ToString() + "'";
        }

        private void Button_print_Click(object sender, EventArgs e)
        {
            SQL = defaultSQL + filtro + especifico;

            try
            {

                SLDocument oSLDocument = new SLDocument();

                System.Data.DataTable dt = new DataTable("ParentTable");
                dt.Columns.Add("ID Archivo Muerto", typeof(string));
                dt.Columns.Add("Nombre", typeof(string));
                dt.Columns.Add("Apellido Paterno", typeof(string));
                dt.Columns.Add("Apellido Materno", typeof(string));
                dt.Columns.Add("Curp", typeof(string));

                dt.Columns.Add("RFC", typeof(string));
                dt.Columns.Add("Nacionalidad", typeof(string));
                dt.Columns.Add("Fecha de Nacimiento", typeof(string));
                dt.Columns.Add("Sexo", typeof(string));
                dt.Columns.Add("Fecha de ingreso", typeof(string));

                //dt.Columns.Add("Perfil", typeof(string));
                dt.Columns.Add("Telefono", typeof(string));
                dt.Columns.Add("Correo", typeof(string));

                ODB.SetCommand(SQL);
                string[,] values = ODB.GetReporte1();

                for (int i = 0; i < 400; i++)
                {
                    if (values[i, 0] != "" && values[i, 0] != null)
                    {

                        dt.Rows.Add(values[i, 0],
                                        values[i, 1],
                                        values[i, 2],
                                        values[i, 3],
                                        values[i, 4],

                                        values[i, 5],
                                        values[i, 6],
                                        values[i, 7],
                                        values[i, 8],
                                        values[i, 9],

                                        //values[i, 10],
                                        values[i, 11],
                                        values[i, 12]);
                    }
                }

                oSLDocument.ImportDataTable(1, 1, dt, true);
                oSLDocument.AutoFitColumn(1, 22, 20);
                string filtrote = comboBox1.Text.ToString();

                string name = "Reporte_Archivo_Muerto_" + DateTime.Now.ToString("MM") + DateTime.Now.ToString("yyyy") + DateTime.Now.ToString("dd") + DateTime.Now.ToString("mm") + "_" + filtrote + ".xls";
                oSLDocument.SaveAs("C:\\Reportes\\" + name);
                new Mensajes.Tipos.MsgBoxOK("Reporte generado con exito").ShowDialog();




            }
            catch (Exception ex) { new Mensajes.Tipos.MsgBoxOK(ex.ToString()).ShowDialog(); }
            finally
            {

            }
        }
    }
}
