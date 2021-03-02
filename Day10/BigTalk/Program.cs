using System;

namespace BigTalk
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            Department dept = new Department();

            IUser iu = DataAcess.CreateUser();

            iu.Insert(user);
            iu.GetUser(1);

            IDepartment id = DataAcess.CreateDepartment();
            id.Insert(dept);
            id.GetDepartment(1);

            Console.Read();
        }
    }
}
