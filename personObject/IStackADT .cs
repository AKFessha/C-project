using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace personObject
{
    //Awet Fessha
    interface IStackADT
    {
        //We define properties and methods we want in the objects that are going to implement this interface
        //We don't add logic or code here, we only define the structure

        void push(int value);	//adds value to list appropriately for a stack 
        int pop();			//remove and return value from list 
        Boolean isEmpty();		//returns true if the stack is empty 
        int size();		//returns number of items in stack 
        String toString();	//override toString to display the stack

    }
}
