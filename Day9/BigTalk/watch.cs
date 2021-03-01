using System;
using System.Collections.Generic;
using System.Text;

namespace BigTalk
{
    class GameObserver
    {
        private string name;
        private Subject sub;
        public GameObserver(string name,Subject sub)
        {
            this.name = name;
            this.sub = sub;
        }
        public void CloseGame() => Console.WriteLine($"{sub.SubjectState}{name}关闭游戏，继续写作业");
    }
    class NBAObserver
    {
        private string name;
        private Subject sub;
        public NBAObserver(string name,Subject sub)
        {
            this.name = name;
            this.sub = sub;
        }
        public void CloseNBA() => Console.WriteLine($"{sub.SubjectState}{name}关闭NBA视频，继续看书");
    }

    interface Subject
    {
        void Notify();
        string SubjectState { get; set; }
    }


    delegate void EventHandler();

    class Teacher : Subject
    {
        public event EventHandler Update;
        private string action;
        public string SubjectState { get; set; }
        public void Notify() => Update();
    }
}
