using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace personObject
{
    class EnglishAssignmentPaper: IScore
    {
        public string title { get; set; }
        public int minmumWordCount { get; set; }
        public string paperText { get; set; }

        //Implementing the properties of the interface
       public float grade { get; set; }
       public float maximum { get; set; }
    }
}
