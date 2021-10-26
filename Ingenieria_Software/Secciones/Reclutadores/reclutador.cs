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

        private string telefono;
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

        public void SetIdReclutador(string idReclutador)
        {
            this.idReclutador = idReclutador;
        }
        public void SetSql(string sql)
        {
            this.sql = sql;
        }
        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public void SetApellidoPaterno(string apellido_paterno)
        {
            this.apellido_paterno = apellido_paterno;
        }
        public void SetApellidoMaterno(string apellido_materno)
        {
            this.apellido_materno = apellido_materno;
        }
        public void SetCurp(string curp)
        {
            this.curp = curp;
        }
        public void SetRfc(string rfc)
        {
            this.rfc = rfc;
        }
        public void SetCorreo(string correo)
        {
            this.correo = correo;
        }
        public void setTelefono(string telefono)
        {
            this.telefono = telefono;
        }
        public void SetDireccionColonia(string direccion_colonia)
        {
            this.direccion_colonia = direccion_colonia;
        }
        public void SetDireccionCalle(string direccion_calle)
        {
            this.direccion_calle = direccion_calle;
        }
        public void SetDireccionNoInt(string direccion_no_int)
        {
            this.direccion_no_int = direccion_no_int;
        }
        public void SetDireccionNoExt(string direccion_no_ext)
        {
            this.direccion_no_ext = direccion_no_ext;
        }
        public void SetDireccionCp(string direccion_cp)
        {
            this.direccion_cp = direccion_cp;
        }
    
        public string GetId()
        {
            return idReclutador;
        }
        public string GetStatus()
        {
            return statusName;
        }
        public string GetNombre()
        {
            return nombre;
        }
        public string GetApellidoPaterno()
        {
            return apellido_paterno;
        }
        public string GetApellidoMaterno()
        {
            return apellido_materno;
        }
        public string GetCurp()
        {
            return curp;
        }
        public string GetRfc()
        {
            return rfc;
        }
        public string GetCorreo()
        {
            return correo;
        }
        public string GetTelefono()
        {
            return telefono;
        }
        public string GetDireccionColonia()
        {
            return direccion_colonia;
        }
        public string GetDireccionCalle()
        {
            return direccion_calle;
        }
        public string GetDireccionNoInt()
        {
            return direccion_no_int;
        }
        public string GetDireccionNoExt()
        {
            return direccion_no_ext;
        }
        public string GetDireccionCp()
        {
            return direccion_cp;
        }
    
        #endregion


        #region MODIFICACION DE DATOS

        public void Clear()
        {
            idReclutador = null; 
            nombre = null;
            apellido_materno = null;
            apellido_paterno = null;
            curp = null;
            rfc = null;
            telefono = null;
            correo = null;
            direccion_colonia = null;
            direccion_calle = null;
            direccion_no_int = null;
            direccion_no_ext = null;
            direccion_cp = null;
        }
        public bool ActualizarRecluta(string idReclutador)
        {
            try
            {
                sql = String.Format("UPDATE `Trabajadores_Bolsa` SET `nombre` = '{0}', " +
                                                                      "`a_paterno` = '{1}', " +
                                                                      "`a_materno`= '{2}', " +
                                                                      "`curp` = '{3}', " +
                                                                      "`rfc` = '{4}', " +
                                                                      "`telefono` = {5}, " +
                                                                      "`correo` = '{6}', " +
                                                                      "`dir_colonia` = '{7}', " +
                                                                      "`dir_calle` = '{8}', " +
                                                                      "`dir_no_int` = '{9}', " +
                                                                      "`dir_no_ext` = '{10}', " +
                                                                      "`dir_cp` = {11} WHERE `idTrabajadorBolsa` = {12}",
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
                                                                      direccion_cp,
                                                                      idReclutador);
                if (ODB.NonQuery(sql)) return true; else return false;
            }catch(Exception ex)
            {
                new Mensajes.Tipos.MsgBoxOK(ex.ToString());
                return false;
            }
        }

        public bool InsertarRecluta()
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

                if (ODB.NonQuery(sql))
                {
                    try
                    {
                        sql = "SELECT `idTrabajadorBolsa` FROM `Trabajadores_Bolsa` ORDER BY `idTrabajadorBolsa` DESC LIMIT 1";
                        ODB.SetCommand(sql);
                        SetIdReclutador(ODB.GetId());
                        sql = null;
                    }
                    catch(Exception ex) { new Mensajes.Tipos.MsgBoxOK("Se agrego el registro pero ocurrio un error que impidio recuperar el ID presionar boton de busqueda para intentar recuperar ID").ShowDialog(); }
                    return true;
                }
                else return false;
            }catch(Exception ex)
            {
                new Mensajes.Tipos.MsgBoxOK(ex.ToString());
                return false;
            }
        }

        public bool EliminarRecluta(string id)
        {
            try
            {
                sql = String.Format("DELETE FROM `Trabajadores_Bolsa` WHERE `idTrabajadorBolsa` = {0}", id);
                if (ODB.NonQuery(sql)) { Clear(); return true; } else { return false; }
                
            }
            catch(Exception ex)
            {
                new Mensajes.Tipos.MsgBoxOK(ex.ToString()).ShowDialog();
            }
            return false;
        }

        public bool BuscarRecluta(string id)
        {
            try
            {
                new Mensajes.Tipos.MsgBoxOK(id).ShowDialog();
                Clear();
                sql =String.Format("SELECT * FROM `Trabajadores_Bolsa` WHERE `idTrabajadorBolsa` = '{0}'",id);
                ODB.SetCommand(sql);
                new Mensajes.Tipos.MsgBoxOK(sql).ShowDialog(); ;
                SetCampos(ODB.GetMultiCampos(17));
                return true;
            }catch(Exception ex)
            {
                ODB.CloseConection();
                new Mensajes.Tipos.MsgBoxOK(ex.ToString()).ShowDialog();
                return false;
            }
        }

        private void SetCampos(string[] campos)
        {
            Clear();
            SetIdReclutador(campos[0]);
            SetNombre(campos[1]);
            SetApellidoPaterno(campos[2]);
            SetApellidoMaterno(campos[3]);
            SetCurp(campos[4]);
            SetRfc(campos[5]);
            setTelefono(campos[6]);
            SetCorreo(campos[7]);

            SetDireccionColonia(campos[8]);
            SetDireccionCalle(campos[9]);
            SetDireccionNoInt(campos[10]);
            SetDireccionNoExt(campos[11]);
            SetDireccionCp(campos[12]);
            
        }
        #endregion
    }
}
