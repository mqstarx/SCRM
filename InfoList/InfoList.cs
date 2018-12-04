using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InfoList
{
    public partial class InfoList: UserControl
    {
        private List<string> m_InfoStrings;

        private int m_FontSize;

        private string m_HeaderText;
        public InfoList()
        {
            
            InitializeComponent();
            m_FontSize = 19;
            m_InfoStrings = new List<string>();
            infoGroupbox.Text = m_HeaderText;
        }

        public List<string> InfoStrings
        {
            get
            {
                return m_InfoStrings;
            }

           /* set
            {
                m_InfoStrings = value;
                if (value != null)
                {
                    for (int i = 0; i < m_InfoStrings.Count; i++)
                    {
                        Label lbl = new Label();
                    
                       
                        lbl.AutoEllipsis = true;
                        lbl.Location = new Point(1, i * 22);
                        lbl.Text = m_InfoStrings[i];
                        lbl.Width = panel.Width - 20;
                        panel.Controls.Add(lbl);

                    }
                }
            }*/
        }

        public int FontSize
        {
            get
            {
                return m_FontSize;
            }

            set
            {
                m_FontSize = value;
            }
        }

        public string HeaderText
        {
            get
            {
                return m_HeaderText;
            }

            set
            {
                m_HeaderText = value;
                infoGroupbox.Text = m_HeaderText;
            }
        }

        public void AddString(string str,  Color clr,int fntSize)
        {
            Label lbl = new Label();

            lbl.Font = new Font("Times New Roman", fntSize);
            lbl.AutoEllipsis = true;
            //lbl.Location = new Point(1, i * 22);
            if(panel.Controls.Count>0)
                lbl.Location = new Point(1,panel.Controls[panel.Controls.Count - 1].Location.Y + 22);
            else
                lbl.Location = new Point(1, 0);
            lbl.ForeColor = clr;
            lbl.Text = str;
            lbl.Width = panel.Width - 20;
            panel.Controls.Add(lbl);
        }
        public void AddString(string str, Color clr)
        {
            Label lbl = new Label();

            lbl.Font = new Font("Times New Roman", m_FontSize);
            lbl.AutoEllipsis = true;
            //lbl.Location = new Point(1, i * 22);
            if (panel.Controls.Count > 0)
                lbl.Location = new Point(1, panel.Controls[panel.Controls.Count - 1].Location.Y + 22);
            else
                lbl.Location = new Point(1, 0);
            lbl.ForeColor = clr;
            lbl.Text = str;
            lbl.Width = panel.Width - 20;
            panel.Controls.Add(lbl);
        }
        public void AddString(string str)
        {
            Label lbl = new Label();

            lbl.Font = new Font("Times New Roman", m_FontSize);
            lbl.AutoEllipsis = true;
            //lbl.Location = new Point(1, i * 22);
            if (panel.Controls.Count > 0)
                lbl.Location = new Point(1, panel.Controls[panel.Controls.Count - 1].Location.Y + 22);
            else
                lbl.Location = new Point(1, 0);
            lbl.ForeColor = Color.Black;
            lbl.Text = str;
            lbl.Width = panel.Width - 20;
            panel.Controls.Add(lbl);
        }
    }
}
