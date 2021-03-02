using System;

namespace BigTalk
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            Department dept = new Department();

            IFactory factory = new SqlServerFactory();
            //IFactory factory = new AccessFactory();

            IUser iu = factory.CreateUser();

            iu.Insert(user);
            iu.GetUser(1);

            IDepartment id = factory.CreateDepartment();
            id.Insert(dept);
            id.GetDepartment(1);

            Console.Read();
        }
    }
}
