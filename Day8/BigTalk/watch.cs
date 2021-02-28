using System;
using System.Collections.Generic;
using System.Text;

namespace BigTalk
{
    class Secretary
    {
        private IList<StockObserver> observers = new List<StockObserver>();
        private string action;

        public void Attach(StockObserver observer)
        {
            observers.Add(observer);
        }

        public void Notiry()
        {
            foreach (StockObserver o in observers)
                o.Update();
        }

        public string SecretaryAction
        {
            get { return action; }
            set { action = value; }
        }
    }

    class StockObserver
    {
        private string name;
        private Secretary sub;
        public StockObserver(string name, Secretary sub)
        {
            this.name = name;
            this.sub = sub;
        }
        public void Update()
        {
            Console.WriteLine("{0}{1}关闭股票行情，继续工作", sub.SecretaryAction, name);
        }
    }
}
