using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace code
{
    abstract class GenericElasticSearch
    {
        public abstract void Handling();
    }

    class ElasticSearch : GenericElasticSearch
    {
        public override void Handling()
        {
            Console.WriteLine("处理ElasticSearch");
        }
    }

    class TemplateElasticSearch : GenericElasticSearch
    {
        public override void Handling()
        {
            Console.WriteLine("处理TemplateElasticSearch");
        }
    }

    class TaskGroupElasticSearch : GenericElasticSearch
    {
        public override void Handling()
        {
            Console.WriteLine("处理TaskGroupElasticSearch");
        }
    }

    class EventsGroupElasticSearch : GenericElasticSearch
    {
        public override void Handling()
        {
            Console.WriteLine("处理EventsGroupElasticSearch");
        }
    }

    class StudentInfoElasticSearch : GenericElasticSearch
    {
        public override void Handling()
        {
            Console.WriteLine("处理StudentInfoElasticSearch");
        }
    }
}
