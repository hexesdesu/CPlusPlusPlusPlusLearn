using System;
using System.Collections.Generic;
using System.Text;

namespace BigTalk
{
    public class Operation
    {
        private double _numberA = 0;
        private double _numberB = 0;

        public double NumberA
        {
            get;
            set;
        }
        public double NumberB
        {
            get;
            set;
        }
        public virtual double GetResult()
        {
            double result = 0;
            return result;
        }
    }
    class OperationAdd:Operation
    {
        public override double GetResult()
        {
            double result = 0;
            result = NumberA + NumberB;
             return result;
        }
    }
    class OperationSub : Operation
    {
        public override double GetResult()
        {
            double result = 0;
            result = NumberA - NumberB;
             return result;
        }
    }
    class OperationMul : Operation
    {
        public override double GetResult()
        {
            double result = 0;
            result = NumberA * NumberB;
             return result;
        }
    }
    class OperationDiv : Operation
    {
        public override double GetResult()
        {
            double result = 0;
            result = NumberA / NumberB;
             return result;
        }
    }
    public class OperationFactory
    {
        public static Operation createOperate(string operate)
        {
            Operation oper = null;
            switch (operate)
            {
                case "+":
                    oper = new OperationAdd();
                    break;
                case "-":
                    oper = new OperationSub();
                    break;
                case "*":
                    oper = new OperationMul();
                    break;
                case "/":
                    oper = new OperationDiv();
                    break;
            }
            return oper;
        }
    }
}
