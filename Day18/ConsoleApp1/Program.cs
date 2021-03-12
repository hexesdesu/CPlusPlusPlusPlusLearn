using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            A c = new C();
            c.M();
            c.M1();
        }
    }

    public class A
    {
        public virtual void M() { Console.WriteLine("A.M()"); }
        public virtual void M1() { Console.WriteLine("A.M1()"); }
    }

    public class B : A
    {
        public sealed override void M() { Console.WriteLine("B.M()"); }
        public override void M1() { Console.WriteLine("B.M1()"); }
    }

    public sealed class C : B
    {
        /* ConsoleApplication1.MSFun.Sealed.C.M()': 
         * cannot override inherited member 'ConsoleApplication1.MSFun.Sealed.B.M()' 
         * because it is sealed */
        //protected override void M() { Console.WriteLine("C.M()"); }  
        public override void M1() { Console.WriteLine("C.M1()"); }
    }
}
