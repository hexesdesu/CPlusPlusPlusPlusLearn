using System;

namespace BigTalk
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            IFactory factory = new SqlServerFactory();
            IUser iu = factory.CreateUser();
            iu.Insert(user);
            iu.GetUser(1);

            Console.Read();
        }
    }
}
