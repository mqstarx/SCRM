using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLib
{
    public class DepInfo
    {
        private string m_Uid;
        public DepInfo()
        {
            m_Uid = Guid.NewGuid().ToString();
        }

        public string Uid
        {
            get
            {
                return m_Uid;
            }
           
        }
    }
}
