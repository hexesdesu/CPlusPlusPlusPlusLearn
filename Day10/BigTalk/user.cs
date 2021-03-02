using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.Configuration;

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

    interface IUser
    {
        void Insert(User user);
        User GetUser(int id);
    }

    interface IDepartment
    {
        void Insert(Department department);
        Department GetDepartment(int id);
    }

    class SqlserverDepartment : IDepartment
    {
        public void Insert (Department department)
        {
            Console.WriteLine("在SQLServer中给Department表增加一条记录");
        }
        public Department GetDepartment(int id)
        {
            Console.WriteLine("在SQLServer中根据ID得到Department表一条记录");
                return null;
        }
    }

    class AccessDepartment : IDepartment
    {
        public void Insert(Department department)
        {
            Console.WriteLine("在Access中给Department表增加一条记录");
        }
        public Department GetDepartment(int id)
        {
            Console.WriteLine("在Access中根据ID得到Department表一条记录");
                return null;
        }
    }

    interface IFactory
    {
        IUser CreateUser();
        IDepartment CreateDepartment();
    }

    class SqlServerFactory:IFactory
    {
        public IUser CreateUser()
        {
            return new SqlserverUser();
        }
        public IDepartment CreateDepartment()
        {
            return new SqlserverDepartment();
        }
    }

    class AccessFactory:IFactory
    {
        public IUser CreateUser()
        {
            return new AccessUser();
        }

        public IDepartment CreateDepartment()
        {
            return new AccessDepartment();
        }
    }

    class SqlserverUser:IUser
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

    class AccessUser : IUser
    {
        public void Insert(User user)
        {
            Console.WriteLine("在Access中给User表增加一条记录");
        }

        public User GetUser(int id)
        {
            Console.WriteLine("在Access中根据ID得到User表一条记录");
            return null;
        }
    }

    class Department
    {
        private int _id;
        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }
        private string _deptName;
        public string DeptName
        {
            get { return _deptName; }
            set { _deptName = value; }
        }
    }

    class DataAcess
    {
        private static readonly string AssemblyName = "AbstractFactoryModel";
        private static readonly string db = ConfigurationManager.AppSettings("DB");

        public static IUser CreateUser()
        {
            string className = AssemblyName + "." + db + "User";
            return (IUser)Assembly.Load(AssemblyName).CreateInstance(className);
        }
        public static IDepartment CreateDepartment()
        {
            string className = AssemblyName + "." + db + "Department";
            return (IDepartment)Assembly.Load(AssemblyName).CreateInstance(className);
        }
    }
}