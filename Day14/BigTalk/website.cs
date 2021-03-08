using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigTalk
{
    abstract class WebSite
    {
        public abstract void Use();
    }

    class ConcreteWebSite : WebSite
    {
        private string name = "";
        public ConcreteWebSite(string name)
        {
            this.name = name;
        }
        public override void Use()
        {
            Console.WriteLine("网站分类：" + name);
        }
    }

    class WebsiteFactory
    {
        private Hashtable flyweithts = new Hashtable();
        public WebSite GetWebsiteCategory(string key)
        {
            if (!flyweithts.ContainsKey(key))
                flyweithts.Add(key, new ConcreteWebSite(key));
            return ((WebSite)flyweithts[key]);
        }
        public int GetWebsiteCount()
        {
            return flyweithts.Count;
        }
    }
}
