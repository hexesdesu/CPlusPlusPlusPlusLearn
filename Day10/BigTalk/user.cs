using System;
using System.Collections.Generic;
using System.Text;

namespace BigTalk
{
    class User
    {
        private int _id;
        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
    }

    class SqlserverUser
    {
        public void Insert(User user)
        {
            Console.WriteLine("在SQLServer中给User表增加一条记录");
        }

        public User GetUser(int id)
        {
            Console.WriteLine("在SQLServer中根据ID得到User表一条记录");
            return null;
        }
    }
}
