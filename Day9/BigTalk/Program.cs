using System;

namespace BigTalk
{
    class Program
    {
        static void Main(string[] args)
        {
            Teacher math = new Teacher();
            GameObserver a = new GameObserver("小明", math);
            NBAObserver b = new NBAObserver("小杨", math);
            math.Update += new EventHandler(a.CloseGame);
            math.Update += new EventHandler(b.CloseNBA);
            math.SubjectState = "数学老师来教室了！";
            math.Notify();

            Console.Read();
        }
    }
}
