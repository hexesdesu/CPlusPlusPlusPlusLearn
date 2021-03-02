using System;
using System.Reflection;
using System.Configuration;

namespace BigTalk
{
    class Program
    {
        static void Main(string[] args)
        {
            IUser result = (IUser)Assembly.Load("AbstractFactoryModel").CreateInstance("AbstractFactoryModel.SqlserverUser");
            Console.Read();
        }
    }
}
