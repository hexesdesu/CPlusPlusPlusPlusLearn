using System;

namespace BigTalk
{
    class Program
    {
        static void Main(string[] args)
        {
            int extrinsicstate = 22;

            FlyweightFactory f = new FlyweightFactory();

            Flyweight fx = f.GetFlyweight("X");
            fx.Operation(--extrinsicstate);

            Flyweight fy = f.GetFlyweight("Y");
            fx.Operation(--extrinsicstate);

            Flyweight fz = f.GetFlyweight("Z");
            fx.Operation(--extrinsicstate);

            Flyweight uf = new UnsharedConcreteFlyweight();

            uf.Operation(--extrinsicstate);

            Console.Read();
        }
    }
}
