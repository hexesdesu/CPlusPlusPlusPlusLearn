using System;

namespace code
{
    class Program
    {
        static void Main(string[] args)
        {
            SearchTypeEnum searchTypeEnum = new SearchTypeEnum();

            Console.WriteLine(searchTypeEnum.TransType2Class("全部"));

            Console.Read();
        }
    }
}
