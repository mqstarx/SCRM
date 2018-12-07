using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoreLib
{
    public  class Cfg
    {

        private string m_DbServer;
        private string m_DbPort;
        private string m_DbUser;
        private string m_DbPassword;
        private string m_DbName;


        private string m_UserUID;

        public Cfg(string m_DbServer, string m_DbPort, string m_DbUser, string m_DbPassword, string m_DbName,string m_UserUID)
        {
            this.m_DbServer = m_DbServer;
            this.m_DbPort = m_DbPort;
            this.m_DbUser = m_DbUser;
            this.m_DbPassword = m_DbPassword;
            this.m_DbName = m_DbName;
            this.m_UserUID = m_UserUID;
        }

        public string DbServer
        {
            get
            {
                return m_DbServer;
            }

            set
            {
                m_DbServer = value;
            }
        }

        public string DbPort
        {
            get
            {
                return m_DbPort;
            }

            set
            {
                m_DbPort = value;
            }
        }

        public string DbUser
        {
            get
            {
                return m_DbUser;
            }

            set
            {
                m_DbUser = value;
            }
        }

        public string DbPassword
        {
            get
            {
                return m_DbPassword;
            }

            set
            {
                m_DbPassword = value;
            }
        }

        public string DbName
        {
            get
            {
                return m_DbName;
            }

            set
            {
                m_DbName = value;
            }
        }

        public string UserUID
        {
            get
            {
                return m_UserUID;
            }

            set
            {
                m_UserUID = value;
            }
        }

        public  static Cfg ReadConfig()
        {
            try
            {
                FileStream fs = new FileStream(Application.StartupPath + @"\" + "config.cfg", FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                string[] cfg_str = sr.ReadToEnd().Split('\n');

                return null;



            }
            catch
            {
                MessageBox.Show("Ошибка чтения конфигурации");
                return null;
            }



        }
    }
}
