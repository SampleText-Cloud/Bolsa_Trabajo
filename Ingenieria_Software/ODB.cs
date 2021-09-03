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

        #region A VEEEEER

        public static string connectionString;
        public static MySqlConnection databaseConnection;
        public static MySqlCommand commandDatabase;
        public static MySqlDataReader reader;
        private static string user;
        public static string getUser()
        {
            return user;
        }


        public static bool testConnection(string user, string password)
        {
            string connectionStringTEST = "datasource=10.0.0.2;port=3306;username=" + user + ";password=" + password + ";database=ReclamosBD;";
            MySqlConnection databaseConnectionTEST = new MySqlConnection(connectionStringTEST);
            try
            {
                databaseConnectionTEST.Open();
                databaseConnectionTEST.Close();
                return true;
            }
            catch (Exception)
            {
                databaseConnectionTEST.Close();
                return false;
            }
        }
        public static void setConnectionString(string username, string password)
        {
            connectionString = "datasource=10.0.0.2;port=3306;username=" + username + ";password=" + password + ";database=ReclamosBD;";
            databaseConnection = new MySqlConnection(connectionString);
            user = username;
        }

        public static void setCommand(string command)
        {
            commandDatabase = new MySqlCommand(command, databaseConnection);
            commandDatabase.CommandTimeout = 60;
        }

        public static void OpenConexion()
        {
            databaseConnection.Open();
        }

        public static void CloseConection()
        {
            databaseConnection.Close();
        }

        public static string getId()
        {
            string row = "";
            reader = commandDatabase.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    row = reader.GetString(0);
                }
            }
            return row;
        }
        public static string[] getMultiId()
        {
            string[] row = new string[500];
            reader = commandDatabase.ExecuteReader();
            if (reader.HasRows)
            {
                int i = 0;
                while (reader.Read())
                {
                    row[i] = reader.GetString(1) + " : " + reader.GetString(0);
                    i++;
                }


            }
            return row;
        }

        public static string[] getMultiIdType()
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

        public static string[] getMultiCampos(int rows)
        {
            string[] row = new string[rows];
            reader = commandDatabase.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    for (int i = 0; i < rows; i++)
                    {
                        row[i] = reader.GetString(i);
                    }
                }
            }
            return row;
        }

        public static string[,] getGeneralReport()
        {
            string[,] row = new string[1000000, 10];
            reader = commandDatabase.ExecuteReader();
            if (reader.HasRows)
            {
                int i = 0;
                while (reader.Read())
                {
                    row[i, 0] = reader.GetString(0);
                    row[i, 1] = reader.GetString(1);
                    row[i, 2] = reader.GetString(2);
                    row[i, 3] = reader.GetString(3);
                    row[i, 4] = reader.GetString(4);
                    row[i, 5] = reader.GetString(5);
                    row[i, 6] = reader.GetString(6);
                    row[i, 7] = reader.GetString(7);
                    row[i, 8] = reader.GetString(8);
                    row[i, 9] = reader.GetString(9);

                    i++;
                }
            }
            return row;
        }

        //public static string
        public static void NonQuery()
        {
            commandDatabase.ExecuteNonQuery();
        }
    }

    #endregion
}

