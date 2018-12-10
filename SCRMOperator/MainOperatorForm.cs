﻿using CoreLib;
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

namespace SCRMOperator
{
    public partial class MainOperatorForm : Form
    {
        private Cfg m_Cfg;
        public MainOperatorForm()
        {
            
            InitializeComponent();
            m_Cfg = Cfg.ReadConfig();
            // UserInfo usr = new UserInfo(new DepInfo("asdasd"), "asdasdas", "asdasdas");
           // propertyGrid1.SelectedObject = usr;



           
           
        }

        private void depView_DepAdd(object sender, EventArgs e)
        {
            DataBase.InsertDepQuery((DepInfo)sender, m_Cfg.DbConnectionString);
            List<object[]> obj_arr =  DataBase.SelectQuery("select depInfo from departments;",m_Cfg.DbConnectionString);
            
        }

        private void refresh_btn_Click(object sender, EventArgs e)
        {
            List<object[]> obj_arr = DataBase.SelectQuery("select depInfo from departments;", m_Cfg.DbConnectionString);
            List<DepInfo> dep_list = new List<DepInfo>();
            foreach (object[] obj in obj_arr)
            {
                MemoryStream ms = new MemoryStream();

                ms.Write(((byte[])obj[0]), 0, ((byte[])obj[0]).Length);
                ms.Position = 0;
                BinaryFormatter bf = new BinaryFormatter();
                DepInfo dep = (DepInfo)bf.Deserialize(ms);
                dep_list.Add(dep);
            }
            depView.DepList = dep_list;

        }
    }
}
