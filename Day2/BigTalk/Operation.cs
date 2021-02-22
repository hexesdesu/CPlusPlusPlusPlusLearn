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
/*
## 尝试markdown画uml图
@startuml
运算类 <.. 简单工厂类

together {
    class 加法类
    class 减法类
    class 乘法类
    class 除法类
}
运算类 <|-- 加法类
运算类 <|-- 减法类
运算类 <|-- 乘法类
运算类 <|-- 除法类

class 运算类{
    +NumberA: double
    +numberB: double
    +GetResult(): double
}

class 简单工厂类{ 
    +createOperate(): 运算类
}

class 加法类{
    +GetResult(): double
}

class 减法类{
    +GetResult(): double
}

class 乘法类{
    +GetResult(): double
}

class 除法类{
    +GetResult(): double
}
@enduml
**/