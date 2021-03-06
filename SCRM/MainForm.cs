﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdvancedControls;
using CoreLib;

namespace SCRM
{
    public partial class MainForm : Form
    {
        private Cfg m_Cfg;
        public MainForm()
        {
            InitializeComponent();
            //toolTip1.SetToolTip(label1, "asdfsdfsdf");
           m_Cfg = Cfg.ReadConfig();
            if (m_Cfg == null)
                this.Close();
        }

        private List<object[]> query(string sql)
        {
           
            MySqlConnection conn = new MySqlConnection(m_Cfg.DbConnectionString);
            conn.Open();
            MySqlCommand sql_comm = new MySqlCommand(sql, conn);

            MySqlDataReader MyDataReader;
            MyDataReader = sql_comm.ExecuteReader();
            List<object[]> res = new List<object[]>();
            while(MyDataReader.Read())
            {
                object[] row = new object[MyDataReader.FieldCount];
                MyDataReader.GetValues(row);
                res.Add(row);

            }


            return res;
        }
        private void insertquery()
        {
           
            MySqlConnection conn = new MySqlConnection(m_Cfg.DbConnectionString);
           // conn.Open();
            MySqlCommand command = new MySqlCommand();
            command.Connection = conn;
            command.CommandText = "INSERT INTO testblob (file) VALUES (?databuff);";

            byte[] databuff = SaveConfig(new TaskInfo("","",DateTime.Now,DateTime.Now,null,null,null), "asd");
            MySqlParameter fileContentParameter = new MySqlParameter("?databuff", MySqlDbType.Blob, databuff.Length);

           
            fileContentParameter.Value = databuff;

           
            command.Parameters.Add(fileContentParameter);

            conn.Open();

            command.ExecuteNonQuery();
        }
        private void MainForm_Shown(object sender, EventArgs e)
        {
          /*  string user_id = query("select id_user from users where secret='qwerty7';")[0][0].ToString();

            List<object[]> jjj = query("select * from tasks where id_isp="+user_id + ";");

            
            foreach(object[] obj in jjj)
            {
                string[] row = new string[4];

                Color clr_back = Color.White;
                Color clr_font = Color.Black;

                row[0] = obj[1].ToString();
                row[1] = ((DateTime)obj[5]).ToString("dd.MM.yyyy");
                row[2] = ((DateTime)obj[7]).ToString("dd.MM.yyyy");

                if(DateTime.Now >= (DateTime)obj[7] )
                {
                    clr_back = Color.Red;
                }

                if ((int)obj[4] == 0)
                    row[3] = "В процессе";
                if ((int)obj[4] == 1)
                    row[3] = "Запрос переноса срока";
                if ((int)obj[4] == 2)
                    row[3] = "На утверждении";
                if ((int)obj[4] == 3)
                    row[3] = "На согласовании";
                if ((int)obj[4] == 4)
                    row[3] = "На согласовании";

            


                ListViewItem lvi = new ListViewItem(row, -1,clr_font,clr_back,null);
                lvi.Tag = obj;
                    tasks_list.Items.Add(lvi);
               // }
            }*/

        }
        private  byte[] SaveConfig(object obj, string filename)
        {
         
                MemoryStream ms = new MemoryStream();
               // fs = new FileStream(Application.StartupPath + @"\" + filename, FileMode.Create, FileAccess.Write, FileShare.Write);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(ms, obj);
                byte[] res = ms.ToArray();

                ms.Close();
                return res;
          


        }

        private void button1_Click(object sender, EventArgs e)
        {

            UserInfo usr = new UserInfo(new DepInfo("ОГК"), "Иванов Сергей Андреевич", "Инженер");

            List<TaskInfo> task_array = new List<TaskInfo>();

            List<UserInfo> arrUsr = new List<UserInfo>();
            arrUsr.Add(usr);


            TaskInfo testTask1 = new TaskInfo("Исполнить п. 6 протокола мероприятия \"Изготовление и выпуск СПС 64 «Экспресс - М»\"", "Проработать вопрос и принять решение по таможенному оформлению при отгрузке изделия (Изготовление и выпуск СПС 64 «Экспресс-М» (для Узбекистана)).", DateTime.Now, DateTime.Parse("23.12.2018"), arrUsr, arrUsr, arrUsr);

            task_array.Add(testTask1);

            task_array.Add(testTask1);
            task_array.Add(testTask1);

            task_array.Add(testTask1);

            taskVivewControl1.CurrentUser = usr;
            taskVivewControl1.TaskItems = task_array;

            // insertquery();



            // infoList1.InfoStrings = arr;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            List<object[]> jjj  =  query("select * from testblob");
          //  byte[] buff = new byte[((byte[])jjj[0][1]).Length];
           // jjj[1].CopyTo(buff, 0);
            ms.Write(((byte[])jjj[0][1]), 0, ((byte[])jjj[0][1]).Length);
            ms.Position = 0;
            BinaryFormatter bf = new BinaryFormatter();
            TaskInfo tas = (TaskInfo)bf.Deserialize(ms);
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {

        }
    }
}
