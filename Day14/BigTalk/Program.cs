using System;

namespace BigTalk
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int extrinsicstate = 22;

            FlyweightFactory f = new FlyweightFactory();

            Flyweight fx = f.GetFlyweight("X");
            fx.Operation(--extrinsicstate);

            Flyweight fy = f.GetFlyweight("Y");
            fx.Operation(--extrinsicstate);

            Flyweight fz = f.GetFlyweight("Z");
            fx.Operation(--extrinsicstate);

            Flyweight uf = new UnsharedConcreteFlyweight();

            uf.Operation(--extrinsicstate);*/

            WebsiteFactory f = new WebsiteFactory();

            WebSite fx = f.GetWebsiteCategory("产品展示");
            fx.Use();
            WebSite fy = f.GetWebsiteCategory("产品展示");
            fy.Use();
            WebSite fz = f.GetWebsiteCategory("产品展示");
            fz.Use();
            WebSite f1 = f.GetWebsiteCategory("博客");
            f1.Use();
            WebSite fm = f.GetWebsiteCategory("博客");
            fm.Use();
            WebSite fn = f.GetWebsiteCategory("博客");
            fn.Use();

            Console.WriteLine("网站分类总数为：{0}", f.GetWebsiteCount());

            Console.Read();
        }
    }
}
