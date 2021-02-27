using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigTalk
{
    class Program
    {
        static void Main(string[] args)
        {
            /*建造者模式
           Director director = new Director();
           Builder b1 = new ConcreteBuilder1();
           Builder b2 = new ConcreteBuilder2();

           director.Construct(b1);
           Product p1 = b1.GetResult();
           p1.Show();

           director.Construct(b2);
           Product p2 = b2.GetResult();
           p2.Show();
           **/

            Secretary tongzizhe = new Secretary();

            StockObserver tongshi1 = new StockObserver("weiguancha", tongzizhe);
            StockObserver tongshi2 = new StockObserver("yiguancha", tongzizhe);

            tongzizhe.Attach(tongshi1);
            tongzizhe.Attach(tongshi2);

            tongzizhe.SecretaryAction = "Boss!";

            tongzizhe.Notiry();

            Console.Read();
        }
    }
}
