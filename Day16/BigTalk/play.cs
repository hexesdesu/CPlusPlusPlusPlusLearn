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
        public void Interpret(PlayContext context)
        {
            if (context.PlayText.Length == 0)
            {
                return;
            }
            else
            {
                string playKey = context.PlayText.Substring(0, 1);
                context.PlayText = context.PlayText.Substring(2);
                double playValue = Convert.ToDouble(context.PlayText.Substring(0, context.PlayText.IndexOf(" ")));
                context.PlayText = context.PlayText.Substring(context.PlayText.IndexOf(" " + 1));
                Excute(playKey, playValue);
            }
        }
        public abstract void Excute(string key, double value);
    }

    class Note : Expression
    {
        public override void Excute(string key, double value)
        {
            string note = "";
            switch (key)
            {
                case "C":
                    note = "1";
                    break;
                case "D":
                    note = "2";
                    break;
                case "E":
                    note = "3";
                    break;
                case "F":
                    note = "4";
                    break;
                case "G":
                    note = "5";
                    break;
                case "A":
                    note = "6";
                    break;
                case "B":
                    note = "7";
                    break;
            }
            Console.Write("{0}", note);
        }
    }

    class Scale : Expression
    {
        public override void Excute(string key, double value)
        {
            string scale = "";
            switch (Convert.ToInt32(value))
            {
                case 1:
                    scale = "低音";
                    break;
                case 2:
                    scale = "中音";
                    break;
                case 3:
                    scale = "高音";
                    break;
            }
            Console.Write("{0}", scale);
        }
    }
}
