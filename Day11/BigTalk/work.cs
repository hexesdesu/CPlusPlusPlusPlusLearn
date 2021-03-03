using System;
using System.Collections.Generic;
using System.Text;

namespace BigTalk
{
    public class Work
    {
        private int hour;
        public int Hour
        {
            get;
            set;
        }
        private bool finish = false;
        public bool TaskFinished
        {
            get;
            set;
        }
        public void WriteProgram()
        {
            if (Hour < 12)
            {
                Console.WriteLine("当前时间：{0}点 上午工作，精神百倍", Hour);
            }
            else if (Hour < 13)
            {
                Console.WriteLine("当前时间：{0}点 饿了，午饭；犯困，午休。", Hour);
            }
            else if (Hour < 17)
            {
                Console.WriteLine("当前时间：{0}点 下午状态还不错，继续努力", Hour);
            }
            else
            {
                if (TaskFinished)
                {
                    Console.WriteLine("当前时间：{0}点 下班回家了", Hour);
                }
                else
                {
                    if (Hour < 21)
                    {
                        Console.WriteLine("当前时间：{0}点 加班哦，疲累至极", Hour);
                    }
                    else
                    {
                        Console.WriteLine("当前时间：{0}点 不行了，睡着了。", Hour);
                    }
                }
            }
        }
    }
}
