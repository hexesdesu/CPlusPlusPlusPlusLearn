using System;

namespace BigTalk
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Operation oper;
                oper = OperationFactory.CreateOperate("+");
                oper.NumberA = 1;
                oper.NumberB = 2;
                double result = oper.GetResult();
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("Something Wrong!" + ex.Message);
            }

        }
    }
}
