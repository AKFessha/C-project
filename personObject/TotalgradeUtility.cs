using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace personObject
{
    class TotalgradeUtility
    {
        private static float totalgrade;
        // let's add a static method that takes parameters which implement the interface.
        // It can be anything that implement the interface 
        // The static method computes the total grade of all  assignments

        public static float TotalGrade(IScore EnglishAssgnimentpaper, IScore ProgrammingAssignmentPaper)
        {

            if (EnglishAssgnimentpaper != null && ProgrammingAssignmentPaper != null)
            {

                totalgrade = (EnglishAssgnimentpaper.grade + ProgrammingAssignmentPaper.grade) / 2;

            }
            return totalgrade;

        }

    }
}
