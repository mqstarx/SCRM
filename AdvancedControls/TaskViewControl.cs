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
       
        private UserInfo m_CurrentUser;

        public List<TaskInfo> TaskItems
        {
            get
            {
                return m_TaskItems;
            }
            set
            {
                m_TaskItems = value;

                if (m_TaskItems != null && m_CurrentUser!=null)
                {
                    for (int i = 0; i < m_TaskItems.Count; i++)
                    {
                       //распределение задач по пользователям

                        foreach(UserInfo usr in m_TaskItems[i].UserIspArray)
                        {
                            if(usr.Uid == m_CurrentUser.Uid)
                            {

                                TaskViewItemIsp tvisp = new TaskViewItemIsp();
                                tvisp.Location = new Point(0,  (i * 170));
                                tvisp.SendMsg += Tvisp_SendMsg;
                                tvisp.SendOnSoglUtv += Tvisp_SendOnSoglUtv;
                                tvisp.PerenosPressed += Tvisp_PerenosPressed;
                                tvisp.CloseTask += Tvisp_CloseTask;
                                tvisp.CurrentIsp = m_CurrentUser;
                                tvisp.TaskInfo = m_TaskItems[i];

                                this.Controls.Add(tvisp);



                            }
                        }
                        

                    }
                }
            }
            
            
        }

        private void Tvisp_CloseTask(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void Tvisp_PerenosPressed(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void Tvisp_SendOnSoglUtv(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void Tvisp_SendMsg(object sender, EventArgs e)
        {
           // throw new NotImplementedException();
        }

        public UserInfo CurrentUser
        {
            get
            {
                return m_CurrentUser;
            }

            set
            {
                m_CurrentUser = value;
            }
        }

        public TaskVivewControl()
        {
            InitializeComponent();
         
        }

     
    }
}
