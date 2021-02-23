using System;
using System.Collections.Generic;
using System.Text;

namespace BigTalk
{
    
    class LeiFeng
    {
        public void Sweep()
        {
            Console.WriteLine("扫地");
        }
        public void Wash()
        {
            Console.WriteLine("洗衣");
        }
        public void BuyRice()
        {
            Console.WriteLine("买米");
        }
    }
    class Undergraduate : LeiFeng 
    { }

    class Volunteer : LeiFeng
    { }

    class SimpleFactory
    {
        public static LeiFeng CreateLeiFeng(string type)
        {
            LeiFeng result = null;
            switch (type)
            {
                case "学雷锋的大学生":
                    result = new Undergraduate();
                    break;
                case "社区志愿者":
                    result = new Undergraduate();
                    break;
            }
            return result;
        }
    }
    interface IFactory
    {
        LeiFeng CreateLeiFeng();
    }
    class UnderGraduateFactory : IFactory
    {
        public LeiFeng CreateLeiFeng()
        {
            return new Undergraduate();
        }
    }

    class VolunteerFactory : IFactory
    {
        public LeiFeng CreateLeiFeng()
        {
            return new Volunteer();
        }
    }

}
