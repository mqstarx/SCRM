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

    public partial class TaskVivewControl: UserControl
   {
        private List<TaskInfo> m_TaskItems;
        private TaskInfo m_Task;

        public List<TaskInfo> TaskItems
        {
            get
            {
                return m_TaskItems;
            }
            set
            {
                m_TaskItems = value;
             /*   for(int i=0;i<m_TaskItems.Count;i++)
                {
                    Panel panel_item = new Panel();
                    panel_item.Width = 900;
                    panel_item.Height = 160;
                    panel_item.BackColor = Color.White;






                    //this.Controls.Add();

                }*/
            }
            
            
        }

        public TaskVivewControl()
        {
            InitializeComponent();
           /* infoList1.AddString("Дата ррррр:ываываыввв ава dsfhfhfh", Color.Red, 12);
            infoList1.AddString("Дата ррррр:ываываывввава");
            infoList1.AddString("Дата ррррр:ываываывввава");
            infoList1.AddString("Дата ррррр:ываываывввава");
            infoList1.AddString("Дата ррррр:ываываывввава");*/
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
