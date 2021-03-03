using System;
using System.Collections.Generic;
using System.Text;

namespace BigTalk
{
    class GameRole
    {
        private int vit;
        public int Vitality
        {
            get { return vit; }
            set { vit = value; }
        }
        private int atk;
        public int Attack
        {
            get { return atk; }
            set { atk = value; }
        }
        private int def;
        public int Defense
        {
            get { return def; }
            set { def = value; }
        }
        public void StateDisplay()
        {
            Console.WriteLine("角色当前状态：");
            Console.WriteLine("体力：{0}", this.vit);
            Console.WriteLine("攻击力：{0}", this.atk);
            Console.WriteLine("防御力：{0}", this.def);
            Console.WriteLine("");
        }
        public void GetInitState()
        {
            this.vit = 100;
            this.atk = 100;
            this.def = 100;
        }
        public void Fight()
        {
            this.vit = 0;
            this.atk = 0;
            this.def = 0;
        }
    }
}
