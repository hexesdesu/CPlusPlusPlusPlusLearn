﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigTalk
{
    class PlayContext
    {
        private string text;
        public string PlayText
        {
            get { return text; }
            set { text = value; }
        }
    }

    abstract class Expression
    {

    }
}
