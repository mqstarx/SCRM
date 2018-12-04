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

        public TaskInfo(string taskName,string taskContent)
        {
           m_Uid = Guid.NewGuid().ToString();
            m_TaskName = taskName;
            m_TaskContent = taskContent;
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
    }
}
