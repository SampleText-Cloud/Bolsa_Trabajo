using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ingenieria_Software
{
    public partial class Index : Form
    {
        public Index()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void ButtonTestBD_Click(object sender, EventArgs e)
        {

        }

        private void PostulantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void PostulantesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                new Secciones.Reclutadores.Administrador().ShowDialog();
            }
            catch (Exception msg)
            {
                new Mensajes.Tipos.MsgBoxOK(msg.ToString()).ShowDialog();
            }
        }

        private void Index_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            lbl_date.Text = DateTime.Now.ToString();
        }

        private void PerfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                new Secciones.Postulantes.Perfiles().ShowDialog();
            }
            catch (Exception msg)
            {
                new Mensajes.Tipos.MsgBoxOK(msg.ToString()).ShowDialog();
            }
        }

        private void PerfilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                new Secciones.Empresa.Perfiles().ShowDialog();
            }
            catch (Exception msg)
            {
                new Mensajes.Tipos.MsgBoxOK(msg.ToString()).ShowDialog();
            }
        }

        private void HorariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                new Secciones.Empresa.Horarios().ShowDialog();
            }
            catch (Exception msg)
            {
                new Mensajes.Tipos.MsgBoxOK(msg.ToString()).ShowDialog();
            }
        }

        private void ArchivoMuertoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                new Secciones.Empresa.ArchivoMuerto().ShowDialog();
            }
            catch (Exception msg)
            {
                new Mensajes.Tipos.MsgBoxOK(msg.ToString()).ShowDialog();
            }
        }

        private void TrabajadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                new Secciones.Empresa.Trabajadores().ShowDialog();
            }
            catch (Exception msg)
            {
                new Mensajes.Tipos.MsgBoxOK(msg.ToString()).ShowDialog();
            }
        }

        private void InformacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                new Secciones.Empresa.Informacion().ShowDialog();
            }
            catch (Exception msg)
            {
                new Mensajes.Tipos.MsgBoxOK(msg.ToString()).ShowDialog();
            }
        }

        private void HabilidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void IdiomasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                new Secciones.Empresa.Idiomas().ShowDialog();
            }
            catch (Exception msg)
            {
                new Mensajes.Tipos.MsgBoxOK(msg.ToString()).ShowDialog();
            }
        }

        private void NacionalidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                new Secciones.Empresa.Nacionalidades().ShowDialog();
            }
            catch (Exception msg)
            {
                new Mensajes.Tipos.MsgBoxOK(msg.ToString()).ShowDialog();
            }
        }

        private void ÁcercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                new Secciones.Empresa.Informacion().ShowDialog();
            }
            catch (Exception msg)
            {
                new Mensajes.Tipos.MsgBoxOK(msg.ToString()).ShowDialog();
            }
        }

        private void TipoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                new Secciones.Empresa.Puesto_Area().ShowDialog();
            }
            catch (Exception msg)
            {
                new Mensajes.Tipos.MsgBoxOK(msg.ToString()).ShowDialog();
            }
        }

        private void PuestoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                new Secciones.Empresa.Puesto_Tipo().ShowDialog();
            }
            catch (Exception msg)
            {
                new Mensajes.Tipos.MsgBoxOK(msg.ToString()).ShowDialog();
            }
        }

        private void ExperienciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                new Secciones.Postulantes.Experiencia().ShowDialog();
            }
            catch (Exception msg)
            {
                new Mensajes.Tipos.MsgBoxOK(msg.ToString()).ShowDialog();
            }
        }

        private void CursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                new Secciones.Empresa.Documentos().ShowDialog();
            }
            catch (Exception msg)
            {
                new Mensajes.Tipos.MsgBoxOK(msg.ToString()).ShowDialog();
            }
        }

        private void CursosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                new Secciones.Empresa.Cursos().ShowDialog();
            }
            catch (Exception msg)
            {
                new Mensajes.Tipos.MsgBoxOK(msg.ToString()).ShowDialog();
            }
        }

        private void ReportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void ReportePostulantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                new Reportes.ReporteCandidatos().ShowDialog();
            }
            catch (Exception msg)
            {
                new Mensajes.Tipos.MsgBoxOK(msg.ToString()).ShowDialog();
            }
        }

        private void ReporteTrabajadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                new Reportes.ReporteTrabajadores().ShowDialog();
            }
            catch (Exception msg)
            {
                new Mensajes.Tipos.MsgBoxOK(msg.ToString()).ShowDialog();
            }
        }

        private void ReporteArchivoMuertoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                new Reportes.ReporteArchivoMuerto().ShowDialog();
            }
            catch (Exception msg)
            {
                new Mensajes.Tipos.MsgBoxOK(msg.ToString()).ShowDialog();
            }
        }
    }
}
