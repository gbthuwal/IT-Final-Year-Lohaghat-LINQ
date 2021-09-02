using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITFinalYearLibrary
{
    public class LectureBase
    {
        public virtual string PrintMessage()
        {
            return "This is IT Final Year Class Library";
        }
        public virtual string PrintMessage(string strMessage)
        {
            return "This is IT Final Year Class Library";
        }
        protected virtual void PrintMessage(string strInputMessage, out string strOutputMessage)
        {
            strOutputMessage = "This Method Have Out Parameter in IT Final Year Class Library";
        }
    }

    public class LectureBase4 : LectureBase
    {
        private void ClassMethids()
        {
            LectureBase lectB = new LectureBase();
            base.PrintMessage("Hi", out string outMsg);
        }
        
    }
    public class LectureBase3 : LectureBase
    {
        public sealed override string PrintMessage()
        {
            base.PrintMessage("Hi", out string outMsg);

            return "This is Overrriden IT Final Year Class Library = " + outMsg;
        }
    }

    public class ITFinalLecture : LectureBase3
    {
        public int x, y;
        public int[] Numbers;

        #region Overriden Methods
        public sealed override string PrintMessage(string strMessage)
        {
            return "This is Overrriden IT Final Year Class Library";
        }

        public override string ToString()
        {
            string str = "";
            foreach (int x in this.Numbers)
            {
                str += x.ToString();
                str += ",";
            }
            return "X=" + this.x + " Y=" + y + " Numbers= " + str;
        }

        #endregion

        private ITFinalLecture()
        {

        }
        public ITFinalLecture(int x, string xy, object z)
        {
            String t; Object b;
        }
        public ITFinalLecture(int x, int y)
        {
            if (x > y)
                y = 2 * x;

            Numbers = new Int32[y];

            this.x = x;
            this.y = y;

            for (int j = 0, i = x; j < y; j++, i++)
            {
                Numbers[j] = i;
            }
        }

        public override string PrintMessage(string strMessage)
        {
            return "This is IT Final Year Class Library" + strMessage;
        }

        public List<int> GetEvenNumbers()
        {
            List<int> list = new List<int>();

            this.PrintMessage("Super Class Message");

            foreach (int i in Numbers)
            {
                if (i % 2 == 0)
                    list.Add(i);
            }
            return list;
        }
    }
}
