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
    public partial class TaskViewItemIsp : UserControl
    {
        private TaskInfo m_TaskInfo;
        private UserInfo m_CurrentIsp;

        public event EventHandler PerenosPressed;
        public event EventHandler SendMsg;
        public event EventHandler SendOnSoglUtv;
        public event EventHandler CloseTask;
        

        public TaskViewItemIsp()
        {
            InitializeComponent();
        }

        public TaskInfo TaskInfo
        {
            get
            {
                return m_TaskInfo;
            }

            set
            {
                m_TaskInfo = value;
                this.staticInfoTask.text1.Text = m_TaskInfo.TaskName;
                this.staticInfoTask.text2.Text = m_TaskInfo.TaskContent;
                
                foreach(AgreementItem itm in m_TaskInfo.UserAgreementArray)
                {
                    if (itm.IsAgreenent == SoglStatus.None)
                        infoListSogl.AddString(itm.User.Name);
                    if (itm.IsAgreenent == SoglStatus.Decline)
                        infoListSogl.AddString(itm.User.Name,Color.Red);
                    if (itm.IsAgreenent == SoglStatus.Accept)
                        infoListSogl.AddString(itm.User.Name, Color.Green);

                }

                foreach (AgreementItem itm in m_TaskInfo.UserUtvlArray)
                {
                    if (itm.IsAgreenent == SoglStatus.None)
                        infoListUtv.AddString(itm.User.Name);
                    if (itm.IsAgreenent == SoglStatus.Decline)
                        infoListUtv.AddString(itm.User.Name, Color.Red);
                    if (itm.IsAgreenent == SoglStatus.Accept)
                        infoListUtv.AddString(itm.User.Name, Color.Green);

                }

                DatesList.AddString("Дата начала: "+m_TaskInfo.DateBegin.ToString("dd.MM.yyyy"));

                if (DateTime.Now >= m_TaskInfo.DateEnd)
                    DatesList.AddString("Срок: "+m_TaskInfo.DateEnd.ToString("dd.MM.yyyy"),Color.Red);
                else
                    DatesList.AddString("Срок: "+m_TaskInfo.DateEnd.ToString("dd.MM.yyyy"));

                dateTimePickerperenos.MinDate = m_TaskInfo.DateEnd;

                if(m_TaskInfo.DatePerenos>DateTime.Parse("12.03.1986"))
                {
                    DatesList.AddString("Запрос переноса на: " + m_TaskInfo.DatePerenos);
                }

                if (m_TaskInfo.DateIspZapros > DateTime.Parse("12.03.1986"))
                {
                    DatesList.AddString("Запрос на согл/утв: " + m_TaskInfo.DateIspZapros);

                }
                if (m_TaskInfo.DateFactEnd > DateTime.Parse("12.03.1986"))
                {
                    DatesList.AddString("Дата факт. заверш. : " + m_TaskInfo.DateIspZapros);
                }

                if (m_TaskInfo.Status == CoreLib.TaskStatus.OnSogl || m_TaskInfo.Status == CoreLib.TaskStatus.OnUtv || m_TaskInfo.Status == CoreLib.TaskStatus.OnSoglPerenos)
                {
                    perenos();

                }
                if (m_TaskInfo.Status == CoreLib.TaskStatus.Closed)
                {
                    isp_comment.Enabled = false;
                    perenos_btn.Enabled = false;
                    dateTimePickerperenos.Enabled = false;
                    agreement_send_btn.Text = "Убрать задачу из списка";
                }

                if(m_TaskInfo.Chat.Count>0)
                {
                    toolTipchat.SetToolTip(isp_comment, m_TaskInfo.GetChatOneString());
                    messages_txb.Text = m_TaskInfo.GetChatOneString();
                }


            }
        }

        public UserInfo CurrentIsp
        {
            get
            {
                return m_CurrentIsp;
            }

            set
            {
                m_CurrentIsp = value;
            }
        }

        private void perenos()
        {
            perenos_btn.Enabled = false;
            dateTimePickerperenos.Enabled = false;
            if (m_TaskInfo.Chat.Count > 0)
                toolTipchat.SetToolTip(isp_comment, m_TaskInfo.GetChatOneString());
            agreement_send_btn.Text = "Отправить сообщение";
        }

        private void perenos_btn_Click(object sender, EventArgs e)
        {
            if (m_TaskInfo == null)
                return;

            m_TaskInfo.DatePerenos = dateTimePickerperenos.Value;
            perenos();
            DatesList.AddString("Запрос переноса на: " + m_TaskInfo.DatePerenos);
            m_TaskInfo.Status = CoreLib.TaskStatus.OnSoglPerenos;
            if (PerenosPressed != null)
                PerenosPressed(m_TaskInfo, null);

        }

        private void agreement_send_btn_Click(object sender, EventArgs e)
        {
            if (m_TaskInfo == null)
                return;

            if (m_TaskInfo.Status == CoreLib.TaskStatus.OnSogl || m_TaskInfo.Status == CoreLib.TaskStatus.OnUtv || m_TaskInfo.Status == CoreLib.TaskStatus.OnSoglPerenos)
            {
                if (isp_comment.Text.Length > 0)
                {
                    
                    m_TaskInfo.Chat.Add(m_CurrentIsp.Name +"("+DateTime.Now.ToString("dd.MM.yyyy") +")" + ": " + isp_comment.Text);
                    isp_comment.Text = "";
                    toolTipchat.SetToolTip(isp_comment, m_TaskInfo.GetChatOneString());
                    // messages_txb.Text = m_TaskInfo.GetChatOneString();
                    messages_txb.Lines = m_TaskInfo.Chat.ToArray();
                    if (SendMsg != null)
                    {
                        SendMsg(m_TaskInfo, null);
                    }
                }

            }
            if(m_TaskInfo.Status == CoreLib.TaskStatus.InProgress)
            {

                if (isp_comment.Text.Length > 0)
                {
                    m_TaskInfo.Chat.Add(m_CurrentIsp.Name + "(" + DateTime.Now.ToString("dd.MM.yyyy") + ")" + ": " + isp_comment.Text);
                    toolTipchat.SetToolTip(isp_comment, m_TaskInfo.GetChatOneString());
                    // messages_txb.Text = m_TaskInfo.GetChatOneString();
                    messages_txb.Lines = m_TaskInfo.Chat.ToArray();
                    m_TaskInfo.DateIspZapros = DateTime.Now;
                    DatesList.AddString("Запрос на согл/утв: " + m_TaskInfo.DateIspZapros);

                    isp_comment.Text = "";
                 

                    if (m_TaskInfo.UserAgreementArray.Count > 0)
                        m_TaskInfo.Status = CoreLib.TaskStatus.OnSogl;
                    else
                        m_TaskInfo.Status = CoreLib.TaskStatus.OnUtv;

                    perenos();

                    if(SendOnSoglUtv!=null)
                    {
                        SendOnSoglUtv(m_TaskInfo, null);
                    }
                  
                }
            }

            if(m_TaskInfo.Status== CoreLib.TaskStatus.Closed)
            {
                if(CloseTask!=null)
                {
                    CloseTask(m_TaskInfo, null);
                }
            }
        }
    }
}
