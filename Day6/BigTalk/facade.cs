using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigTalk
{
    class SubSystemOne
    {
        public void MethodOne()
        {
            Console.WriteLine("SubSystemMethodOne");
        }
    }

    class SubSystemTwo
    {
        public void MethodTwo()
        {
            Console.WriteLine("SubSystemMethodTwo");
        }
    }

    class SubSystemThree
    {
        public void MethodThree()
        {
            Console.WriteLine("SubSystemMethodThree");
        }
    }

    class SubSystemFour
    {
        public void MethodFour()
        {
            Console.WriteLine("SubSystemMethodFour");
        }
    }

    class Facade
    {
        SubSystemOne one;
        SubSystemTwo two;
        SubSystemThree three;
        SubSystemFour four;

        public Facade()
        {
            one = new SubSystemOne();
            two = new SubSystemTwo();
            three = new SubSystemThree();
            four = new SubSystemFour();
        }

        public void MethodA()
        {
            Console.WriteLine("\n MethodGroupA() ----");
            one.MethodOne();
            two.MethodTwo();
            four.MethodFour();
        }

        public void MethodB()
        {
            Console.WriteLine("\n MethodGroupb() ----");
            two.MethodTwo();
            three.MethodThree();
        }
    }
}
