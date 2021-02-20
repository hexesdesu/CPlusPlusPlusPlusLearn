using System;

namespace Day1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Person p = new Person();
            Console.WriteLine(p.ToString());
            Console.ReadKey();
        }
        
        public class Person
        {
            public void CHLASS()
            {
                Console.WriteLine("吃喝拉撒睡");
            }
        }
        public class NBAPlayer
        {
            public void KouLan()
            {
                Console.WriteLine("扣篮");
            }
        }
        public class Student : Person,IKouLanable 
        {
            public void KouLan()
            {
                Console.WriteLine("同扣篮");
            }
        }

        public interface IKouLanable
        {
            public void KouLan();

        }
    }
}
