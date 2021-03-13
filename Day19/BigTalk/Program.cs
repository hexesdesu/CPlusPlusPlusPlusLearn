using System;

namespace BigTalk
{
    class Program
    {
        static void Main(string[] args)
        {
            if ("+".Equals("+"))
            {
                IOperationFactory operationFactory = new AddFactory();
                Operation o = operationFactory.GetOperation();
                o.Num1 = 1;
                o.Num2 = 2;
                Console.WriteLine(o.GetResult());
            }         
        }
    }

    public abstract class Operation
    {
        private double num1;
        private double num2;

        public double Num1
        {
            get;
            set;
        }

        public double Num2
        {
            get;
            set;
        }

        public abstract double GetResult();
    }

    public class Add : Operation
    {
        public override double GetResult()
        {
            return this.Num1 + this.Num2;
        }
    }

    public class Minus : Operation
    {
        public override double GetResult()
        {
            return this.Num1 - this.Num2;
        }
    }

    public interface IOperationFactory
    {
        public Operation GetOperation();
    }

    public class AddFactory : IOperationFactory
    {
        public Operation GetOperation()
        { 
            return new Add();
        }
    }

    public class MinusFactory : IOperationFactory
    {
        public Operation GetOperation()
        {
            return new Minus();
        }
    }
}
