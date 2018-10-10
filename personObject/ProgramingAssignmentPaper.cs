using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace personObject
{
    class ProgramingAssignmentPaper: IScore
    {
        public string problemDescription { get; set; }
        public string materials { get; set; }
        public string solution { get; set; }

        //Implementing the properties of the interface
        public float grade { get; set; }
        public float maximum { get; set; }
    }
}
