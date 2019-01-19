﻿using System;
using Factory.Elements;

namespace Factory.GUI
{
    public class DesignButton: IButton
    {
        public DesignButton()
        {
            Text = "New Button";
        }
        public DesignButton(String text)
        {
            Text = text;
        }

        public string Text { get; set; }
        public void Print()
        {
            Console.WriteLine("<<<& {0} &>>>", Text);
        }
    }
}
