﻿using System;

namespace BigTalk
{
    class Program
    {
        static void Main(string[] args)
        {
            /*WebSiteFactory f = new WebSiteFactory();

            WebSite fx = f.GetWebSiteCategory("产品展示");
            fx.Use(new User("小菜"));
            WebSite fy = f.GetWebSiteCategory("产品展示");
            fy.Use(new User("大鸟"));
            WebSite fz = f.GetWebSiteCategory("产品展示");
            fz.Use(new User("娇娇"));
            WebSite f1 = f.GetWebSiteCategory("博客");
            f1.Use(new User("老顽童"));
            WebSite fm = f.GetWebSiteCategory("博客");
            fm.Use(new User("桃谷六仙"));
            WebSite fn = f.GetWebSiteCategory("博客");
            fn.Use(new User("南海鳄神"));

            Console.WriteLine("得到的网站分类总数为 {0}", f.GetWebsiteCount());*/

            string titleA = "大话设计模式";
            string titleB = "大话设计模";
            titleB = "大话设计模式";
            Console.WriteLine(Object.ReferenceEquals(titleA, titleB));

            Console.Read();
        }
    }
}