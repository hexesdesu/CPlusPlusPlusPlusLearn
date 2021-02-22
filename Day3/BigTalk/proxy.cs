using System;
using System.Collections.Generic;
using System.Text;

namespace BigTalk
{
    interface IGiveGift
    {
        void GiveDolls();
        void GiveFlowers();
        void GiveChocolate();

    }

    class Pursuit : IGiveGift
    {
        SchoolGirl mm;
        public Pursuit(SchoolGirl mm)
        {
            this.mm = mm;
        }
        public void GiveDolls()
        {
            Console.WriteLine(mm.Name + "送你洋娃娃");
        }

        public void GiveFlowers()
        {
            Console.WriteLine(mm.Name + "送你鲜花");
        }

        public void GiveChocolate()
        {
            Console.WriteLine(mm.Name + "送你巧克力");
        }
    }
    class Proxy: IGiveGift
    {
        Pursuit gg;
        public Proxy (SchoolGirl mm)
        {
            gg = new Pursuit(mm);
        }

        public void GiveChocolate()
        {
            gg.GiveChocolate();
        }

        public void GiveDolls()
        {
            gg.GiveDolls();
        }

        public void GiveFlowers()
        {
            gg.GiveFlowers();
        }
    }
}
