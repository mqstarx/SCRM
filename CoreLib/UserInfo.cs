using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLib
{
    public class UserInfo
    {
        private string m_Uid;
        private string m_Name;
        private string m_PostName;
        private string m_DepUid;
        private DepInfo m_Dep;

        public string Uid
        {
            get
            {
                return m_Uid;
            }

            set
            {
                m_Uid = value;
            }
        }

        public string Name
        {
            get
            {
                return m_Name;
            }

            set
            {
                m_Name = value;
            }
        }

        public string PostName
        {
            get
            {
                return m_PostName;
            }

            set
            {
                m_PostName = value;
            }
        }

        public string DepUid
        {
            get
            {
                return m_DepUid;
            }

            set
            {
                m_DepUid = value;
            }
        }

        public DepInfo Dep
        {
            get
            {
                return m_Dep;
            }

            set
            {
                m_Dep = value;
            }
        }

        public UserInfo(DepInfo dep,string name,string post_name)
        {

            m_Uid = Guid.NewGuid().ToString();
            m_Dep = dep;
            m_Name = name;
            m_PostName = post_name ;
            m_DepUid = dep.Uid;
        }

      
    }
}
