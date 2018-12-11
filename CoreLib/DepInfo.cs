using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLib
{
    [Serializable]
    public class DepInfo
    {
        private string m_Uid;
        private string m_DepName;
        private int m_id_InDb=-1;
    
        public DepInfo(string name)
        {
            m_Uid = Guid.NewGuid().ToString();
            m_DepName = name;
        }

        public string Uid
        {
            get
            {
                return m_Uid;
            }
           
        }

        public string DepName
        {
            get
            {
                return m_DepName;
            }

            set
            {
                m_DepName = value;
            }
        }

        public int Id_InDb
        {
            get
            {
                return m_id_InDb;
            }

            set
            {
                m_id_InDb = value;
            }
        }
    }
}
