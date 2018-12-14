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
    public partial class UsersViewItem : UserControl
    {
        public event EventHandler UserInfoChanged;
        public event EventHandler UserDeleted;

        private UserInfo m_User;

        private List<DepInfo> m_DepList;
        

        public UserInfo User
        {
            get
            {
                return m_User;
            }

            set
            {
                m_User = value;
                usr_name_txb.Text = m_User.Name;
                post_name_txb.Text = m_User.PostName;

                if(m_DepList==null)
                    dep_cmb.Items.Add(m_User.Dep);
                
            }
        }

        private void SetCmbSelected()
        {
            for(int i=0;i<dep_cmb.Items.Count;i++)
            {
                if (((DepInfo)dep_cmb.Items[i]).Uid == m_User.DepUid)
                {
                    dep_cmb.SelectedIndex = i;
                    break;
                }

            }
        }
        public List<DepInfo> DepList
        {
            get
            {
                return m_DepList;
            }

            set
            {
                m_DepList = value;
                if (m_DepList != null)
                {
                    dep_cmb.Items.AddRange(m_DepList.ToArray());
                    SetCmbSelected();
                }


            }
        }

        public UsersViewItem()
        {
            InitializeComponent();
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            if (usr_name_txb.Text != "" && post_name_txb.Text!="")
            {
                m_User.Name = usr_name_txb.Text;
                m_User.PostName = post_name_txb.Text;
                m_User.Dep = (DepInfo)dep_cmb.SelectedItem;
                if (UserInfoChanged != null)
                    UserInfoChanged(m_User, null);
                usr_name_txb.ReadOnly = true;
                post_name_txb.ReadOnly = true;
                dep_cmb.Enabled = false;
                edit_btn.Enabled = false;
            }
        }

        private void post_name_txb_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            usr_name_txb.ReadOnly = false;
            post_name_txb.ReadOnly = false;
            dep_cmb.Enabled = true;
            edit_btn.Enabled = true;
        }

        private void usr_name_txb_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            post_name_txb_MouseDoubleClick(null, null);
        }

        private void del_dep_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Действительно удалить?", "Подверждение!", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (UserDeleted != null)
                {
                    UserDeleted(this, null);
                }
            }
        }

        private void dep_cmb_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            post_name_txb_MouseDoubleClick(null, null);
        }
    }
}
