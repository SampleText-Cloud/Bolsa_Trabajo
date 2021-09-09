using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ingenieria_Software.Secciones.Reclutadores
{
    class reclutador
    {
        #region DATOS

        private string idReclutador;
        private string nombre;
        private string apellido_paterno;
        private string apellido_materno;
        private string curp;
        private string rfc;

        private int telefono;
        private string correo;

        private string direccion_colonia;
        private string direccion_calle;
        private string direccion_no_int;
        private string direccion_no_ext;
        private string direccion_cp;

        private int status;
        private string statusName;

        private string sql;

        #endregion

        #region GET & SET

        public void setIdReclutador(string idReclutador)
        {
            this.idReclutador = idReclutador;
        }
        public void setSql(string sql)
        {
            this.sql = sql;
        }
        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public void setApellidoPaterno(string apellido_paterno)
        {
            this.apellido_paterno = apellido_paterno;
        }
        public void setApellidoMaterno(string apellido_materno)
        {
            this.apellido_materno = apellido_materno;
        }
        public void setCuro(string curp)
        {
            this.curp = curp;
        }
        public void setRfc(string rfc)
        {
            this.rfc = rfc;
        }
        public void setCorreo(string correo)
        {
            this.correo = correo;
        }
        public void setDireccionColonia(string direccion_colonia)
        {
            this.direccion_colonia = direccion_colonia;
        }
        public void setDireccionCalle(string direccion_calle)
        {
            this.direccion_calle = direccion_calle;
        }
        public void setDireccionNoInt(string direccion_no_int)
        {
            this.direccion_no_int = direccion_no_int;
        }
        public void setDireccionNoExt(string direccion_no_ext)
        {
            this.direccion_no_ext = direccion_no_ext;
        }
        public void setDireccionCp(string direccion_cp)
        {
            this.direccion_cp = direccion_cp;
        }

        public string getId()
        {
            return idReclutador;
        }
        public string getStatus()
        {
            return statusName;
        }
        public string getNombre()
        {
            return nombre;
        }
        public string getApellidoPaterno()
        {
            return apellido_paterno;
        }
        public string getApellidoMaterno()
        {
            return apellido_materno;
        }
        public string getCuro()
        {
            return curp;
        }
        public string getRfc()
        {
            return rfc;
        }
        public string getCorreo()
        {
            return correo;
        }
        public string getDireccionColonia()
        {
            return direccion_colonia;
        }
        public string getDireccionCalle()
        {
            return direccion_calle;
        }
        public string getDireccionNoInt()
        {
            return direccion_no_int;
        }
        public string getDireccionNoExt()
        {
            return direccion_no_ext;
        }
        public string getDireccionCp()
        {
            return direccion_cp;
        }

        #endregion


        #region SUBIDA DE DATOS

        public bool actualizarRecluta()
        {
            try
            {
               
                if (ODB.NonQuery(sql)) return true; else return false;
            }catch(Exception ex)
            {
                return false;
            }
        }

        public bool insertarRecluta()
        {
            try
            {
                sql = String.Format("INSERT INTO `Trabajadores_Bolsa`(`nombre`, " +
                                                                     "`a_paterno`, " +
                                                                     "`a_materno`, " +
                                                                     "`curp`, " +
                                                                     "`rfc`, " +
                                                                     "`telefono`, " +
                                                                     "`correo`, " +
                                                                     "`dir_colonia`, " +
                                                                     "`dir_calle`, " +
                                                                     "`dir_no_int`, " +
                                                                     "`dir_no_ext`, " +
                                                                     "`dir_cp`) VALUES ('{0}','{1}','{2}','{3}','{4}',{5},'{6}','{7}','{8}','{9}','{10}',{11})",
                                                                     nombre,
                                                                     apellido_paterno,
                                                                     apellido_materno,
                                                                     curp,
                                                                     rfc,
                                                                     telefono,
                                                                     correo,
                                                                     direccion_colonia,
                                                                     direccion_calle,
                                                                     direccion_no_int,
                                                                     direccion_no_ext,
                                                                     direccion_cp);
                if (ODB.NonQuery(sql)) return true; else return false;
            }catch(Exception ex)
            {
                return false;
            }
        }

        public bool eliminarRecluta()
        {
            return false;
        }

        #endregion
    }
}
