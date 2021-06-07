using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace WpfLesson6
{
    public class ViewModel
    {
        public MyColor MyColor_ { get; set; }
        public ObservableCollection<MyColor> {get;set;}
        public ViewModel()
        {
            
        }
        private MyColor myColor = new MyColor();

        public MyColor MyColor_
        {
            get { return myColor; }
            set { myColor = value; }
        }
}
}
