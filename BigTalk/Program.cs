using System;

namespace BigTalk
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("A:");
                string strNumberA = Console.ReadLine();
                Console.Write("+-*/");
                string strOperate = Console.ReadLine();
                Console.Write("B:");
                string strNumberB = Console.ReadLine();
                string strResult = "";
                strResult = Convert.ToString(Operation.GetResult(Convert.ToDouble(strNumberA),
                    Convert.ToDouble(strNumberB), strOperate));
                Console.WriteLine("Result:" + strResult);
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Something Wrong!" + ex.Message);
            }

        }
    }
}
