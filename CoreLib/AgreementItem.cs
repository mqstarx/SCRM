using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLib
{
   

   public class AgreementItem
    {
        private UserInfo m_User;
        private SoglStatus m_IsAgreenent;

        public UserInfo User
        {
            get
            {
                return m_User;
            }

            set
            {
                m_User = value;
            }
        }

        public SoglStatus IsAgreenent
        {
            get
            {
                return m_IsAgreenent;
            }

            set
            {
                m_IsAgreenent = value;
            }
        }

        public AgreementItem(UserInfo m_User, SoglStatus m_IsAgreenent)
        {
            this.m_User = m_User;
            this.m_IsAgreenent = m_IsAgreenent;
        }
    }
}
