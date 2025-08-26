using System;

namespace Assemble1
{
    public class AssemblyOneClass1
    {
        protected internal int ID = 101;
    }
    public class AssemblyOneClass2 : AssemblyOneClass1
    {
        public void SampleMethod()
        {
            AssemblyOneClass1 A1 = new AssemblyOneClass1();
            Console.Write(A1.ID);
        }
    }
}
