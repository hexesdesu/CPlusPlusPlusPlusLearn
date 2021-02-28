using System;

namespace BigTalk
{
    class Program
    {
        static void Main(string[] args)
        {
            Boss huhansan = new Boss();

            StockObserver tongshi1 = new StockObserver("weiguancha", huhansan);
            StockObserver tongshi2 = new StockObserver("yiguancha", huhansan);

            huhansan.Attach(tongshi1);
            huhansan.Attach(tongshi2);

            huhansan.SubjectState = "I'm back!";

            huhansan.Notify();

            Console.Read();
        }
    }
}
