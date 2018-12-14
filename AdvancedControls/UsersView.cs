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

        private List<DepInfo> m_DepList;


        /// <summary>
        /// Происходит при мзменении имени объекта
        /// </summary>
        public event EventHandler UserNameChanged;

        /// <summary>
        /// происходит при добавлении нового пользователя
        /// </summary>
        public event EventHandler UserAdd;

        /// <summary>
        /// Удаление пользователя
        /// </summary>
        public event EventHandler UserDeleted;


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
                        UsersViewItem dvi = new UsersViewItem();
                        dvi.UserInfoChanged += Uvi_UserInfoChanged;
                        dvi.UserDeleted += Uvi_UserDeleted; ;
                        dvi.Location = new Point(0, i * 36);
                        dvi.Width = panel.Width;
                        dvi.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                        if (m_DepList != null)
                            dvi.DepList = m_DepList;
                        dvi.User = m_UsersList[i];
                        panel.Controls.Add(dvi);
                    }
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
            }
        }

        

        private void add_btn_Click(object sender, EventArgs e)
        {
            if (new_userfio_txb.Text != "" && new_user_post_txb.Text!="" && dep_cmb.SelectedIndex!=-1)
            {

                UserInfo usr = new UserInfo(((DepInfo)dep_cmb.SelectedItem), new_userfio_txb.Text, new_user_post_txb.Text);
                

                if (UserAdd != null)
                {
                    UserAdd(usr, null);


                }
                UsersViewItem uvi = new UsersViewItem();
                uvi.UserInfoChanged += Uvi_UserInfoChanged;
                uvi.UserDeleted += Uvi_UserDeleted;
                if (panel.Controls.Count > 0)
                    uvi.Location = new Point(0, panel.Controls[panel.Controls.Count - 1].Location.Y + 36);
                else
                    uvi.Location = new Point(0, 0);
                uvi.User = usr;
                uvi.Width = panel.Width;
                uvi.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                uvi.DepList = m_DepList;
                panel.Controls.Add(uvi);
                if (m_UsersList == null)
                    m_UsersList = new List<UserInfo>();
                m_UsersList.Add(usr);
                new_userfio_txb.Text = "";
                new_user_post_txb.Text = "";
                dep_cmb.SelectedIndex = -1;

            }
        }

        private void Uvi_UserDeleted(object sender, EventArgs e)
        {
            if (UserDeleted != null)
            {
                UserDeleted(((UsersViewItem)sender).User, null);
            }
            //  panel.Controls.Remove((Control)sender);
            foreach (UserInfo u in m_UsersList)
            {
                if (((UsersViewItem)sender).User.Uid == u.Uid)
                {
                    m_UsersList.Remove(u);
                    break;
                }
            }
            panel.Controls.Clear();
            this.UsersList = m_UsersList;

        }

        private void Uvi_UserInfoChanged(object sender, EventArgs e)
        {
            if (UserNameChanged != null)
                UserNameChanged(sender, null); ;
        }
    }
}
