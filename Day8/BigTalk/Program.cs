using System;

namespace BigTalk
{
    class Program
    {
        static void Main(string[] args)
        {
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
