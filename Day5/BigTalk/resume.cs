using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigTalk
{
    class Resume: ICloneable
    {
        private string name;
        private string sex;
        private string age;
        private string timeArea;
        private string company;

        private WorkExperience work;

        public Resume(string name)
        {
            this.name = name;
            work = new WorkExperience();
        }

        public void SetPersonalInfo(string sex, string age)
        {
            this.sex = sex;
            this.age = age;
        }

        public void SetWorkExperience(string workDate,string company)
        {
            work.WorkDate = workDate;
            work.Company = company;
        }

        public void Display()
        {
            Console.WriteLine("{0}{1}{2}", name, sex, age);
            Console.WriteLine("工作经历：{0}{1}", work.WorkDate ,company);
        }

        public Object Clone()
        {
            return (Object)this.MemberwiseClone();
        }

        class WorkExperience
        {
            private string workDate;
            
            public string WorkDate
            {
                get;
                set;
            }

            private string company;

            public string Company
            {
                get;
                set;
            }
        }
    }
}