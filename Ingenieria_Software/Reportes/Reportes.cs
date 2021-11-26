using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpreadsheetLight;

namespace Ingenieria_Software.Reportes
{
    public partial class Reportes : Form
    {
        public Reportes()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void Button_R1_Click(object sender, EventArgs e)
        {
            int indice = 0;
            try
            {
                string pathFile = "C:\\Reportes\\REPORTE_CANDIDATOS.xls";

                SLDocument oSLDocument = new SLDocument();

                System.Data.DataTable dt = new DataTable("ParentTable");
                dt.Columns.Add("ID Trabajador", typeof(string));
                dt.Columns.Add("Nombre", typeof(string));
                dt.Columns.Add("Apellido Paterno", typeof(string));
                dt.Columns.Add("Apellido Materno", typeof(string));
                dt.Columns.Add("Curp", typeof(string));

                dt.Columns.Add("RFC", typeof(string));
                dt.Columns.Add("Nacionalidad", typeof(string));
                dt.Columns.Add("Fecha de nacimiento", typeof(string));
                dt.Columns.Add("Sexo", typeof(string));
                dt.Columns.Add("Fecha de ingreso", typeof(string));

                dt.Columns.Add("Perfil", typeof(string));
                dt.Columns.Add("Telefono", typeof(string));
                dt.Columns.Add("Correo", typeof(string));
                dt.Columns.Add("Colonia", typeof(string));
                dt.Columns.Add("Calle", typeof(string));

                dt.Columns.Add("Numero Interior", typeof(string));
                dt.Columns.Add("Numero exterior", typeof(string));
                dt.Columns.Add("Codigo Postal", typeof(string));
                dt.Columns.Add("Documento1", typeof(string));
                dt.Columns.Add("Documento2", typeof(string));

                dt.Columns.Add("Documento3", typeof(string));
                dt.Columns.Add("Documento4", typeof(string));

                ODB.SetCommand("SELECT * FROM `Candidato` ");
                string[,] values = ODB.GetReporte1();
               
                for(int i=0; i < 400; i++)
                {
                    indice = i;
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

                                        values[i, 10],
                                        values[i, 11],
                                        values[i, 12],
                                        values[i, 13],
                                        values[i, 14],

                                        values[i, 15],
                                        values[i, 16],
                                        values[i, 17],
                                        values[i, 18],
                                        values[i, 19],

                                        values[i, 20],
                                        values[i, 21]);
                    }
                }

                oSLDocument.ImportDataTable(1, 1, dt, true);
                oSLDocument.AutoFitColumn(1,22,20);

                oSLDocument.SaveAs(pathFile);

                new Mensajes.Tipos.MsgBoxOK("Reporte generado con exito").ShowDialog();
            }
            catch(Exception ex) { new Mensajes.Tipos.MsgBoxOK(ex.ToString() + indice).ShowDialog();}
            finally
            {
                
            }
        }

        private void TableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button_R2_Click(object sender, EventArgs e)
        {
            int indice = 0;
            try
            {
                string pathFile = "C:\\Reportes\\REPORTE_EMPLEADOS.xls";

                SLDocument oSLDocument = new SLDocument();

                System.Data.DataTable dt = new DataTable("ParentTable");
                dt.Columns.Add("ID Trabajador", typeof(string));
                dt.Columns.Add("Nombre", typeof(string));
                dt.Columns.Add("Apellido Paterno", typeof(string));
                dt.Columns.Add("Apellido Materno", typeof(string));
                dt.Columns.Add("Curp", typeof(string));

                dt.Columns.Add("RFC", typeof(string));
                dt.Columns.Add("Nacionalidad", typeof(string));
                dt.Columns.Add("Fecha de nacimiento", typeof(string));
                dt.Columns.Add("Sexo", typeof(string));
                dt.Columns.Add("Fecha de ingreso", typeof(string));

                dt.Columns.Add("Perfil", typeof(string));
                dt.Columns.Add("Telefono", typeof(string));
                dt.Columns.Add("Correo", typeof(string));
                dt.Columns.Add("Colonia", typeof(string));
                dt.Columns.Add("Calle", typeof(string));

                dt.Columns.Add("Numero Interior", typeof(string));
                dt.Columns.Add("Numero exterior", typeof(string));
                dt.Columns.Add("Codigo Postal", typeof(string));
                dt.Columns.Add("Documento1", typeof(string));
                dt.Columns.Add("Documento2", typeof(string));

                dt.Columns.Add("Documento3", typeof(string));
                dt.Columns.Add("Documento4", typeof(string));

                ODB.SetCommand("SELECT * FROM `Trabajadores` ");
                string[,] values = ODB.GetReporte1();

                for (int i = 0; i < 400; i++)
                {
                    indice = i;
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

                                        values[i, 10],
                                        values[i, 11],
                                        values[i, 12],
                                        values[i, 13],
                                        values[i, 14],

                                        values[i, 15],
                                        values[i, 16],
                                        values[i, 17],
                                        values[i, 18],
                                        values[i, 19],

                                        values[i, 20],
                                        values[i, 21]);
                    }
                }

                oSLDocument.ImportDataTable(1, 1, dt, true);
                oSLDocument.AutoFitColumn(1, 22, 20);

                oSLDocument.SaveAs(pathFile);

                new Mensajes.Tipos.MsgBoxOK("Reporte generado con exito").ShowDialog();
            }
            catch (Exception ex) { new Mensajes.Tipos.MsgBoxOK(ex.ToString() + indice).ShowDialog(); }
            finally
            {

            }
        }

        private void Button_R3_Click(object sender, EventArgs e)
        {
            int indice = 0;
            try
            {
                string pathFile = "C:\\Reportes\\REPORTE_ARCHIVO_MUERTO.xls";

                SLDocument oSLDocument = new SLDocument();

                System.Data.DataTable dt = new DataTable("ParentTable");
                dt.Columns.Add("ID Trabajador", typeof(string));
                dt.Columns.Add("Nombre", typeof(string));
                dt.Columns.Add("Apellido Paterno", typeof(string));
                dt.Columns.Add("Apellido Materno", typeof(string));
                dt.Columns.Add("Curp", typeof(string));

                dt.Columns.Add("RFC", typeof(string));
                dt.Columns.Add("Nacionalidad", typeof(string));
                dt.Columns.Add("Fecha de nacimiento", typeof(string));
                dt.Columns.Add("Sexo", typeof(string));
                dt.Columns.Add("Fecha de ingreso", typeof(string));

                dt.Columns.Add("Perfil", typeof(string));
                dt.Columns.Add("Telefono", typeof(string));
                dt.Columns.Add("Correo", typeof(string));
                dt.Columns.Add("Colonia", typeof(string));
                dt.Columns.Add("Calle", typeof(string));

                dt.Columns.Add("Numero Interior", typeof(string));
                dt.Columns.Add("Numero exterior", typeof(string));
                dt.Columns.Add("Codigo Postal", typeof(string));
                dt.Columns.Add("Documento1", typeof(string));
                dt.Columns.Add("Documento2", typeof(string));

                dt.Columns.Add("Documento3", typeof(string));
                dt.Columns.Add("Documento4", typeof(string));

                ODB.SetCommand("SELECT * FROM `ArchivoMuerto` ");
                string[,] values = ODB.GetReporte1();

                for (int i = 0; i < 400; i++)
                {
                    indice = i;
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

                                        values[i, 10],
                                        values[i, 11],
                                        values[i, 12],
                                        values[i, 13],
                                        values[i, 14],

                                        values[i, 15],
                                        values[i, 16],
                                        values[i, 17],
                                        values[i, 18],
                                        values[i, 19],

                                        values[i, 20],
                                        values[i, 21]);
                    }
                }

                oSLDocument.ImportDataTable(1, 1, dt, true);
                oSLDocument.AutoFitColumn(1, 22, 20);

                oSLDocument.SaveAs(pathFile);

                new Mensajes.Tipos.MsgBoxOK("Reporte generado con exito").ShowDialog();
            }
            catch (Exception ex) { new Mensajes.Tipos.MsgBoxOK(ex.ToString() + indice).ShowDialog(); }
            finally
            {

            }
        }
    }
}
