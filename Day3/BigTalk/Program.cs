using System;

namespace BigTalk
{
    class Program
    {
        static void Main(string[] args)
        {
            SchoolGirl jiaojiao = new SchoolGirl();
            jiaojiao.Name = "李娇娇";
            Proxy daili = new Proxy(jiaojiao);

            daili.GiveDolls();
            daili.GiveFlowers();
            daili.GiveChocolate();
        }
    }
}
