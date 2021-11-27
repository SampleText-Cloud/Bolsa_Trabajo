using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ingenieria_Software
{
    class ODB
    {

        #region ODB DATOS


        
        public static MySqlCommand commandDatabase;
        public static MySqlDataReader reader;
        //private static string user,password;
        private static readonly string root = "bgmcssughpkynluy1abp-mysql.services.clever-cloud.com";
        private static readonly string db = "bgmcssughpkynluy1abp";
        private static readonly string usr = "ub3kxcxyalxsyiwk";
        private static readonly string pass = "GXvokCJC5qXgHmrJHQ2P";
        private static readonly string connectionString = String.Format("datasource={0};port=3306;username={1};password={2};database={3};", root, usr, pass, db);
        public static MySqlConnection databaseConnection = new MySqlConnection(connectionString);


        #endregion

        #region METODOS AUXILIARES
        /*public static string GetUser()
        {
            return user;
        }
        */



        public static bool Connection()
        {
            
            try
            {
                databaseConnection.Open();
                databaseConnection.Close();
                return true;
            }
            catch (Exception)
            {
                databaseConnection.Close();
                return false;
            }
        }
       

        public static void SetCommand(string command)
        {
            commandDatabase = new MySqlCommand(command, databaseConnection){CommandTimeout=60};
        }

        public static void OpenConexion()
        {
            databaseConnection.Open();
        }

        public static void CloseConection()
        {
            databaseConnection.Close();
        }

        public static string GetId()
        {
            string row = "";
            try
            {
                OpenConexion();
                
                reader = commandDatabase.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        row = reader.GetString(0);
                    }
                }
                CloseConection();
            }
            catch (Exception ex)
            {
                new Mensajes.Tipos.MsgBoxOK(ex.ToString()).ShowDialog();
                
            }
            return row;

        }

        public static string[,] GetReporte1()
        {

            string[,] row = new string[500,100];
            try
            {
                OpenConexion();
                reader = commandDatabase.ExecuteReader();
                if (reader.HasRows)
                {
                    int i = 0;
                    while (reader.Read())
                    {
                        row[i ,0] = reader.GetString(0);
                        row[i, 1] = reader.GetString(1);
                        row[i, 2] = reader.GetString(2);
                        row[i, 3] = reader.GetString(3);
                        row[i, 4] = reader.GetString(4);

                        row[i, 5] = reader.GetString(5);
                        row[i, 6] = reader.GetString(6);
                        row[i, 7] = reader.GetString(7);
                        row[i, 8] = reader.GetString(8);
                        row[i, 9] = reader.GetString(9);

                        row[i, 10] = reader.GetString(10);
                        row[i, 11] = reader.GetString(11);
                        row[i, 12] = reader.GetString(12);

                        i++;
                    }


                }
            }
            catch (Exception ex)
            {
                new Mensajes.Tipos.MsgBoxOK(ex.ToString()).ShowDialog();
            }
            finally
            {
                CloseConection();
            }
            return row;
        }

        public static string[] GetMultiId()
        {
            
            string[] row = new string[500];
            try
            {
                OpenConexion();
                reader = commandDatabase.ExecuteReader();
                if (reader.HasRows)
                {
                    int i = 0;
                    while (reader.Read())
                    {
                        row[i] = reader.GetString(1);
                        i++;
                    }


                }
            }
            catch(Exception ex)
            {
                new Mensajes.Tipos.MsgBoxOK(ex.ToString()).ShowDialog();
            }
            finally
            {
                CloseConection();
            }
            return row;
        }

        public static string[] GetMultiDatos()
        {

            string[] row = new string[500];
            try
            {
                OpenConexion();
                reader = commandDatabase.ExecuteReader();
                if (reader.HasRows)
                {
                    int i = 0;
                    while (reader.Read())
                    {
                        row[i] = reader.GetString(0);
                        i++;
                    }


                }
            }
            catch (Exception ex)
            {
                new Mensajes.Tipos.MsgBoxOK(ex.ToString()).ShowDialog();
            }
            finally
            {
                CloseConection();
            }
            return row;
        }


        public static string[] GetMultiIdType()
        {
            string[] row = new string[500];
            reader = commandDatabase.ExecuteReader();
            if (reader.HasRows)
            {
                int i = 0;
                while (reader.Read())
                {
                    row[i] = reader.GetString(0);
                    i++;
                }


            }
            return row;
        }

        public static string[] GetMultiCampos(int rows)
        {
            string[] row = new string[rows];
            try
            {
                OpenConexion();
                
                reader = commandDatabase.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        for (int i = 0; i < rows; i++)
                        {
                            if (reader.GetString(i) != null)
                            {
                                row[i] = reader.GetString(i);
                            }
                        }
                    }
                }
                new Mensajes.Tipos.MsgBoxOK("OPERACION EXITOSA").ShowDialog();
            }
            catch (Exception ex)
            {
                new Mensajes.Tipos.MsgBoxOK(ex.ToString()).ShowDialog();
            }
            finally
            {
                CloseConection();
            }
            return row;
        }

      
        //public static string
        public static void NonQuery()
        {
            commandDatabase.ExecuteNonQuery();
        }

        public static void NonQuery(string sql)
        {   
            try
            {
                OpenConexion();
                SetCommand(sql);
                NonQuery();
                new Mensajes.Tipos.MsgBoxOK("OPERACION EXITOSA").ShowDialog();

            }catch(Exception ex)
            {
                new Mensajes.Tipos.MsgBoxOK(ex.ToString()).ShowDialog();
            }
            finally
            {
                CloseConection();
            }

            

        }
    }

    #endregion
}

