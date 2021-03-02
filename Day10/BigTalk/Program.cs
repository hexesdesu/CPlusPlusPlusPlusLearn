using System;

namespace BigTalk
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            SqlserverUser su = new SqlserverUser();
            su.Insert(user);
            su.GetUser(1);

            Console.Read();
        }
    }
}
