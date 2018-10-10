using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace personObject
{
    //This interface defines the grading system for each assignment
    interface IScore
    {
        //We define properties and methods we want in the objects that are going to implement this interface
        //We don't add logic or code here, we only define the structure
        float grade { get; set; }
        float maximum { get; set; }
    }
}
