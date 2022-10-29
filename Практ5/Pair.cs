using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Практ5
{
     class Pair
    {
        //public int Para1 { get; set; }
        //public int Para2 { get; set; }
        private int para1;
        private int para2;
        public int Para1
        {
            get
            {
                return para1;
            }
            set
            {
                if (value % 2 == 0)
                {
                    para1 = value;
                }
                else
                {
                    MessageBox.Show("Первое число в паре не четное");
                }

            }
        }
        public int Para2
        {
            get
            {
                return para2;
            }
            set
            {
                if (value % 2 == 0)
                {
                    para2 = value;
                }
                else
                {
                    MessageBox.Show("Второе число в паре не четное");
                }
            }
        }
        public void multiplication(Pair value1, Pair value2, out int par1,out int par2)
        {
            par1 = value1.Para1 * value2.Para1;
            par2 = value1.Para2 * value2.Para2;
        }
    }
}
