using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoreLib;

namespace AdvancedControls
{
    public partial class UsersView : UserControl
    {
        private List<UserInfo> m_UsersList;
        public UsersView()
        {
            InitializeComponent();
        }

        public List<UserInfo> UsersList
        {
            get
            {
                return m_UsersList;
            }

            set
            {
                m_UsersList = value;
                if (m_UsersList != null)
                {
                    for (int i = 0; i < m_UsersList.Count; i++)
                    {
                        
                    }
                }

            }
        }
    }
}
