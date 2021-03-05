using System;
using System.Collections.Generic;
using System.Text;

namespace BigTalk
{
    class Request
    {
        private string requestType;
        public string RequestType
        {
            get { return requestType; }
            set { requestType = value; }
        }
        private string requestContent;
        public string RequestConteng
        {
            get { return requestContent; }
            set { requestContent = value; }
        }
        private int number;
        public int Number
        {
            get { return number; }
            set { number = value; }
        }
    }

    /*class Manager
    {
        protected string name;
        public Manager(string name) { this.name = name; }
        public 
    }*/
}
