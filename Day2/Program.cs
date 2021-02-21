using System;

namespace Day2
{
    class Program
    {
        static void Main(string[] args)
        {
            ISwimming swim = new XPDuck();
            swim.Swim();
            Console.ReadKey();
        }
    }
    public class RealDuck : ISwimming
    {
        public void Swim()
        {
            Console.WriteLine("真的鸭子会游泳");
        }
    }

    public class MuDuck : RealDuck
    {

    }

    public class XPDuck : ISwimming
    {
        public void Swim()
        {
            Console.WriteLine("飘着游泳");
        }
    }

    public interface ISwimming
    {
        void Swim();
    }
}
