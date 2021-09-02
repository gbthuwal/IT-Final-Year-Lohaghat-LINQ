using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITFinalYearLibrary
{
    class ITFinalLecture2
    {
        private int _rollNo;
        
        public int RollNo
        {
            get { return _rollNo; }
            set { _rollNo = value; }
        }

        public string Name
        {
            get;
            set;
        }
    }

    class MySchool
    {
        ITFinalLecture2 obj = new ITFinalLecture2();
        public void GetProperties()
        {
            obj.Name = "Deepak Joshi";
            obj.RollNo = 0101902321;
        }

    }
}
