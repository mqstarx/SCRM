using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLib
{
    public class TaskInfo
    {
        private string m_Uid;

        private string m_TaskName;

        private string m_TaskContent;

        private TaskStatus m_Status = TaskStatus.InProgress;

        private List<UserInfo> m_UserIspArray;
        private List<AgreementItem> m_UserAgreementArray;
        private List<AgreementItem> m_UserUtvlArray;

        private DateTime m_DateBegin;
        private DateTime m_DateEnd;
        private DateTime m_DateFactEnd = DateTime.Parse("12.03.1986");
        private DateTime m_DateIspZapros= DateTime.Parse("12.03.1986");
        private DateTime m_DatePerenos= DateTime.Parse("12.03.1986");

        private List<string> m_Chat;


        public TaskInfo(string taskName,string taskContent, DateTime m_DateBegin, DateTime m_DateEnd,List<UserInfo> isp,List<UserInfo> utv,List<UserInfo> sogl)
        {
           m_Uid = Guid.NewGuid().ToString();
            m_TaskName = taskName;
            m_TaskContent = taskContent;
            this.m_DateBegin = m_DateBegin;
            this.m_DateEnd = m_DateEnd;
            m_UserAgreementArray = new List<AgreementItem>();
            m_UserIspArray = new List<UserInfo>();
            m_UserUtvlArray = new List<AgreementItem>();
            m_Chat = new List<string>();
            if(isp!=null)
                m_UserIspArray.AddRange(isp);

            if (utv != null)
            {
                foreach (UserInfo usr in utv)
                {

                    m_UserUtvlArray.Add(new AgreementItem(usr, SoglStatus.None));
                }
            }
            if (sogl != null)
            {
                foreach (UserInfo sog in sogl)
                {

                    m_UserAgreementArray.Add(new AgreementItem(sog, SoglStatus.None));
                }
            }


        }


        public string Uid
        {
            get
            {
                return m_Uid;
            }
           
        }

        public string TaskName
        {
            get
            {
                return m_TaskName;
            }

            set
            {
                m_TaskName = value;
            }
        }

        public string TaskContent
        {
            get
            {
                return m_TaskContent;
            }

            set
            {
                m_TaskContent = value;
            }
        }


        //статус всей заявки
        public TaskStatus Status
        {
            get
            {
                return m_Status;
            }

            set
            {
                m_Status = value;
            }
        }

        /// <summary>
        /// список исполнителей
        /// </summary>
        public List<UserInfo> UserIspArray
        {
            get
            {
                return m_UserIspArray;
            }

            set
            {
                m_UserIspArray = value;
            }
        }
        /// <summary>
        /// список согласующих
        /// </summary>
        public List<AgreementItem> UserAgreementArray
        {
            get
            {
                return m_UserAgreementArray;
            }

            set
            {
                m_UserAgreementArray = value;
            }
        }
        /// <summary>
        /// Список утверждающих
        /// </summary>
        public List<AgreementItem> UserUtvlArray
        {
            get
            {
                return m_UserUtvlArray;
            }

            set
            {
                m_UserUtvlArray = value;
            }
        }

        /// <summary>
        /// дата начала задачи
        /// </summary>
        public DateTime DateBegin
        {
            get
            {
                return m_DateBegin;
            }

            set
            {
                m_DateBegin = value;
            }
        }

        /// <summary>
        /// срок завершения
        /// </summary>
        public DateTime DateEnd
        {
            get
            {
                return m_DateEnd;
            }

            set
            {
                m_DateEnd = value;
            }
        }

        /// <summary>
        /// Фактический срок завершения
        /// </summary>
        public DateTime DateFactEnd
        {
            get
            {
                return m_DateFactEnd;
            }

            set
            {
                m_DateFactEnd = value;
            }
        }

        /// <summary>
        /// Дата запроса на согласование или утверждения
        /// </summary>
        public DateTime DateIspZapros
        {
            get
            {
                return m_DateIspZapros;
            }

            set
            {
                m_DateIspZapros = value;
            }
        }

        /// <summary>
        /// запрашиваемая дата переноса
        /// </summary>
        public DateTime DatePerenos
        {
            get
            {
                return m_DatePerenos;
            }

            set
            {
                m_DatePerenos = value;
            }
        }

        /// <summary>
        /// сообщения пользователей;
        /// </summary>
        public List<string> Chat
        {
            get
            {
                return m_Chat;
            }

            set
            {
                m_Chat = value;
            }
        }


        public string GetChatOneString()
        {
            string result = "";
            foreach(string str in m_Chat)
            {
                result += str + "\n";
            }
            return result;
        }

    }
}
