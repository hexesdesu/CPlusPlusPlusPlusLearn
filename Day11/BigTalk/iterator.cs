using System;
using System.Collections.Generic;
using System.Text;

namespace BigTalk
{
    abstract class Iterator
    {
        public abstract object First();
        public abstract object Next();
        public abstract bool IsDone();
        public abstract object CurrentItem();
    }

    abstract class Aggregate
    {
        public abstract Iterator CreateIterator();
    }

    class ConcreteIterator : Iterator
    {
        private ConcreteAggregate aggregate;
        private int current = 0;
        public ConcreteIterator(ConcreteAggregate aggregate)
        {
            this.aggregate = aggregate;
        }
        public override object First()
        {
            return aggregate[0];
        }
        public override object Next()
        {
            object ret = null;
            current++;
            if(current < aggregate.Count)
            {
                ret = aggregate[current];
            }
            return ret;
        }
        public override bool IsDone()
        {
            return current >= aggregate.Count ? true : false;
        }
        public override object CurrentItem()
        {
            return aggregate[current];
        }
    }

    class ConcreteIteratorDesc : Iterator
    {
        private ConcreteAggregate aggregate;
        private int current = 0;
        public ConcreteIteratorDesc(ConcreteAggregate aggregate)
        {
            this.aggregate = aggregate;
            current = aggregate.Count - 1;
        }
        public override object First()
        {
            return aggregate[aggregate.Count - 1];
        }
        public override object Next()
        {
            object ret = null;
            current--;
            if (current < aggregate.Count)
            {
                ret = aggregate[current];
            }
            return ret;
        }
        public override bool IsDone()
        {
            return current < 0 ? true : false;
        }
        public override object CurrentItem()
        {
            return aggregate[current];
        }
    }

    class ConcreteAggregate : Aggregate
    {
        private IList<object> items = new List<object>();
        public override Iterator CreateIterator()
        {
            return new ConcreteIterator(this);
        }
        public int Count
        {
            get { return items.Count; }
        }
        public object this[int index]
        {
            get { return items[index]; }
            set { items.Insert(index, value); }
        }
    }
}
