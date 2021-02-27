﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BigTalkWin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Pen p = new Pen(Color.Yellow);
            PersonThinBuilder ptb = new PersonThinBuilder(pictureBox1.CreateGraphics(), p);
            PersonDirector pdThin = new PersonDirector(ptb);
            pdThin.CreatePerson();

            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        
       abstract class PersonBuilder
            {
                protected Graphics g;
                protected Pen p;

                public PersonBuilder(Graphics g,Pen p)
                {
                    this.g = g;
                    this.p = p;
                }

                public abstract void BuildHead();
                public abstract void BuildBody();
                public abstract void BuildArmLeft();
                public abstract void BuildArmRight();
                public abstract void BuildLegLeft();
                public abstract void BuildLegRight();
            }

        class PersonThinBuilder : PersonBuilder
        {
            public PersonThinBuilder(Graphics g,Pen p) : base(g, p) { }

            public override void BuildHead()
            {
                g.DrawEllipse(p, 50, 20, 30, 30);
            }
            public override void BuildBody()
            {
                g.DrawRectangle(p, 60, 50, 10, 50);
            }
            public override void BuildArmLeft()
            {
                g.DrawLine(p, 60, 50, 40, 100);
            }
            public override void BuildArmRight()
            {
                g.DrawLine(p, 70, 50, 90, 100);
            }
            public override void BuildLegLeft()
            {
                g.DrawLine(p, 60, 100, 45, 150);
            }
            public override void BuildLegRight()
            {
                g.DrawLine(p, 79, 100, 85, 150);
            }
        }

        class PersonDirector
        {
            private PersonBuilder pb;
            public PersonDirector (PersonBuilder pb)
            {
                this.pb = pb;
            }
            public void CreatePerson()
            {
                pb.BuildHead();
                pb.BuildBody();
                pb.BuildArmLeft();
                pb.BuildArmRight();
                pb.BuildLegLeft();
                pb.BuildLegRight();
            }
        }
    }

       
   
}
