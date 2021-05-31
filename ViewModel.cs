using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace WpfLesson6
{
    class ViewModel 
    {
        private MyColor myColor = new MyColor();

        public MyColor MyColor_
        {
            get { return myColor; }
            set { myColor = value; }
        }

        void test()
        {
        }
    }
}
