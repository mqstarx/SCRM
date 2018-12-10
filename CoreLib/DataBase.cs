using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;


namespace CoreLib
{
    public class DataBase
    {
        private static byte[] ObjectToByteArray(object obj)
        {

            MemoryStream ms = new MemoryStream();
            // fs = new FileStream(Application.StartupPath + @"\" + filename, FileMode.Create, FileAccess.Write, FileShare.Write);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(ms, obj);
            byte[] res = ms.ToArray();

            ms.Close();
            return res;



        }
        public static List<object[]> SelectQuery(string sql,string connection_string)
        {

            MySqlConnection conn = new MySqlConnection(connection_string);
            conn.Open();
            MySqlCommand sql_comm = new MySqlCommand(sql, conn);

            MySqlDataReader MyDataReader;
            MyDataReader = sql_comm.ExecuteReader();
            List<object[]> res = new List<object[]>();
            while (MyDataReader.Read())
            {
                object[] row = new object[MyDataReader.FieldCount];
                MyDataReader.GetValues(row);
                res.Add(row);

            }


            return res;
        }
        public static void InsertDepQuery(DepInfo depInfo,string connection_string)
        {

            MySqlConnection conn = new MySqlConnection(connection_string);
            // conn.Open();
            MySqlCommand command = new MySqlCommand();
            command.Connection = conn;
            command.CommandText = "INSERT INTO departments (depInfo) VALUES (?databuff);";

            byte[] databuff = ObjectToByteArray(depInfo);
            MySqlParameter fileContentParameter = new MySqlParameter("?databuff", MySqlDbType.Blob, databuff.Length);


            fileContentParameter.Value = databuff;


            command.Parameters.Add(fileContentParameter);

            conn.Open();

            command.ExecuteNonQuery();
        }
    }
}
