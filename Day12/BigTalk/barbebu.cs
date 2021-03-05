/*using System;
using System.Collections.Generic;
using System.Text;

namespace BigTalk
{
    public class Barbecuer
    {
        public void BakeMutton()
        {
            Console.WriteLine("烤羊肉串！");
        }
        public void BakeChickenWing()
        {
            Console.WriteLine("烤鸡翅！");
        }
    }

    public abstract class Command
    {
        protected Barbecuer receiver;
        public Command(Barbecuer receiver)
        {
            this.receiver = receiver;
        }
        abstract public void ExcuteCommmand();
    }

    class BakeMuttonCommand : Command
    {
        public BakeMuttonCommand(Barbecuer receiver) : base(receiver) { }
        public override void ExcuteCommmand()
        {
            receiver.BakeMutton();
        }
    }

    class BakeChickenWingCommand : Command
    {
        public BakeChickenWingCommand(Barbecuer receiver) : base(receiver) { }
        public override void ExcuteCommmand()
        {
            receiver.BakeChickenWing();
        }
    }

    public class Waiter
    {
        private IList<Command> orders = new List<Command>();
        public void SetOrder(Command command)
        {
            if (command.ToString() == "命令模式.BakeChickenWingCommand")
            {
                Console.WriteLine("服务员：鸡翅没有了，请点别的烧烤。");
            }
            else
            {
                orders.Add(command);
                Console.WriteLine("增加订单：" + command.ToString() + "时间：" + DateTime.Now.ToString());
            }
        }
        public void CancelOrder(Command command)
        {
            orders.Remove(command);
            Console.WriteLine("取消订单：" + command.ToString() + "时间：" + DateTime.Now.ToString());
        }
        public void Notify()
        {
            foreach(Command cmd in orders)
            {
                cmd.ExcuteCommmand();
            }
        }
    }
}
*/