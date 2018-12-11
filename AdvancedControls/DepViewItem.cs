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
    public partial class DepViewItem : UserControl
    {
       
        /// <summary>
        /// Происходит при мзменении имени объекта
        /// </summary>
        public event EventHandler DepNameChanged;
        public event EventHandler DepDeleted;
        public DepViewItem()
        {
            InitializeComponent();
        }

        private DepInfo m_Dep;

        public DepInfo Dep
        {
            get
            {
                return m_Dep;
            }

            set
            {
                m_Dep = value;
                dep_name_txb.Text = m_Dep.DepName;
            }
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            if(dep_name_txb.Text!="")
            {
                m_Dep.DepName = dep_name_txb.Text;
                if (DepNameChanged != null)
                    DepNameChanged(m_Dep, null);
                dep_name_txb.ReadOnly = true;
                edit_btn.Enabled = false;
            }
        }

        private void dep_name_txb_TextChanged(object sender, EventArgs e)
        {

        }

        private void dep_name_txb_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            dep_name_txb.ReadOnly = false;
            edit_btn.Enabled = true;
        }

        private void del_dep_btn_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Действительно удалить?","Подверждение!", MessageBoxButtons.OKCancel)==DialogResult.OK)
            {
                if(DepDeleted!=null)
                {
                    DepDeleted(this, null);
                }
            }
        }
    }
}
