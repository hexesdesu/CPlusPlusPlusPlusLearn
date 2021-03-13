using System;

namespace BigTalk
{
    class Program
    {
        static void Main(string[] args)
        {
            Operation o = OperationFactory.GetOperation("-");
            o.Num1 = 1;
            o.Num2 = 2;
            Console.WriteLine(o.GetResult());
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

    public class OperationFactory
    {
        public static Operation GetOperation (string operation)
        {
            if ("+".Equals(operation))
            {
                return new Add();
            }
            else if ("-".Equals(operation))
            {
                return new Minus();
            }
            else
            {
                {
                    return null;
                }
            }
        }
    }
}
