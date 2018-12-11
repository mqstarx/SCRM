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
    public partial class DepView : UserControl
    {
        private List<DepInfo> m_DepList;
        /// <summary>
        /// Происходит при мзменении имени объекта
        /// </summary>
        public event EventHandler DepNameChanged;

        /// <summary>
        /// происходит при добавлении нового отдела
        /// </summary>
        public event EventHandler DepAdd;

        /// <summary>
        /// Удаление отдела
        /// </summary>
        public event EventHandler DepDeleted;

        public DepView()
        {
            InitializeComponent();
           
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
                    panel.Controls.Clear();
                    for (int i = 0; i < m_DepList.Count; i++)
                    {
                        DepViewItem dvi = new DepViewItem();
                        dvi.DepNameChanged += Dvi_DepNameChanged;
                        dvi.DepDeleted += Dvi_DepDeleted;
                        dvi.Location = new Point(0, i * 36);
                        dvi.Width = panel.Width;
                        dvi.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                        dvi.Dep = m_DepList[i];
                        panel.Controls.Add(dvi);
                    }
                }


            }
        }

        private void Dvi_DepDeleted(object sender, EventArgs e)
        {
            if (DepDeleted != null)
            {
                DepDeleted(((DepViewItem)sender).Dep, null);
            }
          //  panel.Controls.Remove((Control)sender);
            foreach(DepInfo d in m_DepList)
            {
                if(((DepViewItem)sender).Dep.Uid==d.Uid)
                {
                    m_DepList.Remove(d);
                    break;
                }
            }
            panel.Controls.Clear();
            this.DepList = m_DepList;
            
           

        }

        private void Dvi_DepNameChanged(object sender, EventArgs e)
        {
            if (DepNameChanged != null)
                DepNameChanged(sender, null);
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            if (new_dep_txb.Text != "")
            {
                
                DepInfo de = new DepInfo(new_dep_txb.Text);

                if (DepAdd != null)
                {
                    DepAdd(de, null);


                }
                DepViewItem dvi = new DepViewItem();
                dvi.DepNameChanged += Dvi_DepNameChanged;
                dvi.DepDeleted += Dvi_DepDeleted;
                if (panel.Controls.Count > 0)
                    dvi.Location = new Point(0, panel.Controls[panel.Controls.Count - 1].Location.Y + 36);
                else
                    dvi.Location = new Point(0, 0);
                 dvi.Dep = de;
                dvi.Width = panel.Width ;
                dvi.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;

                panel.Controls.Add(dvi);
                if(m_DepList==null)
                    m_DepList = new List<DepInfo>();
                m_DepList.Add(de);
                new_dep_txb.Text = "";

            }
        }
    }
}
