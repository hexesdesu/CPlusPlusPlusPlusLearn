using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigTalk
{
    abstract class AbstractExpression
    {
        public abstract void Interpret(Context context);
    }

    class TerminalExpression: AbstractExpression
    {
        public override void Interpret(Context context)
        {
            Console.WriteLine("终端解释器");
        }
    }

    class NonterminalExpression : AbstractExpression
    {
        public override void Interpret(Context context)
        {
            Console.WriteLine("非终端解释器");
        }
    }

    class Context
    {
        private string input;
        public string Input
        {
            get { return input; }
            set { input = value; }
        }
        private string output;
        public string Output
        {
            get { return output; }
            set { output = value; }
        }
    }
}
