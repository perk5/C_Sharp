using System;
using Assemble1;


namespace Assembly2 
{
    public class AssemblyTwoClass1 : AssemblyOneClass1
    {

        public void Print()
        {
            //AssemblyTwoClass1 A1 = new AssemblyTwoClass1();
            base.ID = 101;

            AssemblyTwoClass1 A2 = new AssemblyTwoClass1();
            A2.ID = 102;
        }        
    }
}

    
