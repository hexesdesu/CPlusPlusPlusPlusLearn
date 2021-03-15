using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            A a1 = new A();
            A a2 = new B();
            B b = new B();
            C c = new C();
            D d = new D();

            Console.WriteLine("1--" + a1.Show(b));
            Console.WriteLine("2--" + a1.Show(c));
            Console.WriteLine("3--" + a1.Show(d));
            Console.WriteLine("4--" + a2.Show(b));
            Console.WriteLine("5--" + a2.Show(c));
            Console.WriteLine("6--" + a2.Show(d));
            Console.WriteLine("7--" + b.Show(b));
            Console.WriteLine("8--" + b.Show(c));
            Console.WriteLine("9--" + b.Show(d)); 
        }
    }

    public class A
    {
        public string Show(D obj)
        {
            return ("A and D");
        }

        public string Show(A obj)
        {
            return ("A and A");
        }
    }

    public class B : A
    {
        public String Show(B obj)
        {
            return ("B and B");
        }

        public String Show(A obj)
        {
            return ("B and A");
        } 
    }

    public class C : B { }

    public class D : B { }
}
