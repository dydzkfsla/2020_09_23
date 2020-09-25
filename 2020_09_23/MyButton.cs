using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _2020_09_23
{
    delegate void ClickDelegate();

    class ButtonTest
    {
        public event ClickDelegate Click;

        public void ButtonClick()
        {
            Click();
        }
    }

    class MyButton
    {
        static void Main()
        {
            ButtonTest btn1 = new ButtonTest();
            btn1.Click += Button1_Click;

            ButtonTest btn2 = new ButtonTest();
            btn2.Click += Button2_Click;

            btn1.ButtonClick();
            btn2.ButtonClick();
        }

        private static void Button2_Click()
        {
            Console.WriteLine("btn2 버튼 클릭");
        }

        private static void Button1_Click()
        {
            Console.WriteLine("btn1 버튼 클릭");
        }
    }
}
