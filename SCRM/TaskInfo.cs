using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCRM
{
    [Serializable]
   public class TaskInfo
    {
        private string m_descr;
        private string m_name;
        private int m_idusers;
        //sdfgsdfsdfsdfsdf
        public string Descr
        {
            get
            {
                return m_descr;
            }

            set
            {
                m_descr = value;
            }
        }

        public string Name
        {
            get
            {
                return m_name;
            }

            set
            {
                m_name = value;
            }
        }

        public int Idusers
        {
            get
            {
                return m_idusers;
            }

            set
            {
                m_idusers = value;
            }
        }

        public TaskInfo()
        {
            Descr = "edwedwedwedwedwedwed";
            Idusers = 234223;
            Name = "asdada";
        }
    }
}
