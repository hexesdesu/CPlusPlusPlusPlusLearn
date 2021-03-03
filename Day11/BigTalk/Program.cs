using System;

namespace BigTalk
{
    class Program
    {
        static void Main(string[] args)
        {
            Target target = new Adapter();
            target.Reqest();

            Console.Read();
        }
    }
}
